using ExecDash.DataAccess.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace ExecDash.DataAccess.Infrastructure
{
    public class CommandInvoker : ICommandInvoker
    {
        private readonly IDbCommandContext dbContext;
        public CommandInvoker(IDbCommandContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public long Invoke(ICommand command)
        {
            long result = 0;

            using (IDbConnection conn = this.dbContext.Connection)
            {
                using (IDbTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        dbContext.Transaction = transaction;
                        result = command.Execute(dbContext);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            return result;
        }
        public long Invoke(IList<ICommand> commands)
        {
            long totalRowAffected = 0;

            using (IDbConnection conn = this.dbContext.Connection)
            {

                using (IDbTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        dbContext.Transaction = transaction;

                        foreach (ICommand command in commands)
                        {
                            var rowAffected = command.Execute(this.dbContext);

                            totalRowAffected += (rowAffected < 0 ? 0 : rowAffected);
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            return totalRowAffected;
        }
    }
}
