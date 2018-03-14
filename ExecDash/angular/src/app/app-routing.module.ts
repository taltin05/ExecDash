import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { IndexComponent } from "./index/index.component";
import { ErrorPageComponent } from "./common/error-page/error-page.component";
import { PageNotFoundComponent } from "./common/page-not-found/pagenotfound.component";

const routes: Routes = [
    { path: '', redirectTo: 'Index', pathMatch: 'full' },
    { path: 'Index', component: IndexComponent },
    { path: 'ErrorPage', component: ErrorPageComponent },
    { path: '**', component: PageNotFoundComponent }
];

@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [RouterModule]
})

export class AppRoutingModule { }