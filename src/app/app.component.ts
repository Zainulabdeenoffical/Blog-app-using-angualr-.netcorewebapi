import { Component } from '@angular/core';
import {MatButtonModule} from '@angular/material/button';
import { HeaderComponent } from "./Components/header/header.component";
import { FooterComponent } from "./Components/footer/footer.component";
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [MatButtonModule, HeaderComponent, FooterComponent,RouterModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'blogapp';
}
