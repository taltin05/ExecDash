import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'; 

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { IndexComponent } from './index/index.component';
import { PropertiesComponent } from "./properties/properties.component";
import { PropertyDetailComponent } from "./property-detail/property-detail.component";
import { ErrorPageComponent } from "./common/error-page/error-page.component";
import { PageNotFoundComponent } from "./common/page-not-found/pagenotfound.component";


@NgModule({
  declarations: [
      AppComponent,     
      IndexComponent,
      PropertiesComponent,
      PropertyDetailComponent,
      ErrorPageComponent,
      PageNotFoundComponent
  ],
  imports: [     
      AppRoutingModule,
      BrowserModule,
      FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
