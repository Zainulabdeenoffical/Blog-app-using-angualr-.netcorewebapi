import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { blog } from './types/blog';

@Injectable({
  providedIn: 'root'
})
export class BlogService {
htpp = inject(HttpClient);
  constructor() { }
  getfeatureblog()
  {
    return this.htpp.get<blog[]>('https://localhost:7261/api/blog/featured');
  }
}
