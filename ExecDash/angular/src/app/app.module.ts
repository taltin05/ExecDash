import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { IndexComponent } from './index/index.component';
import { ErrorPageComponent } from "./common/error-page/error-page.component";
import { PageNotFoundComponent } from "./common/page-not-found/pagenotfound.component";

@NgModule({
  declarations: [
      AppComponent,     
      IndexComponent,
      ErrorPageComponent,
      PageNotFoundComponent
  ],
  imports: [     
      AppRoutingModule,
      BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
