import { Component, Input } from '@angular/core';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import { RouterLink, RouterModule } from '@angular/router';
import { blog } from '../../types/blog';

@Component({
  selector: 'app-blogs',
  imports: [MatCardModule,MatButtonModule,RouterModule],
  templateUrl: './blogs.component.html',
  styleUrl: './blogs.component.scss'
})
export class BlogsComponent {

  @Input() blog! :blog;
}
