import { Component } from '@angular/core';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import { RouterLink, RouterModule } from '@angular/router';
@Component({
  selector: 'app-blogs-card',
  imports: [MatCardModule,MatButtonModule,RouterModule],
  templateUrl: './blogs-card.component.html',
  styleUrl: './blogs-card.component.scss'
})
export class BlogsCardComponent {

}
