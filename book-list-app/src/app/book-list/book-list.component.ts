import { Component } from '@angular/core';
import { Book } from '../book';

@Component({
  selector: 'app-book-list',
  standalone: true,
  imports: [],
  templateUrl: './book-list.component.html',
  styleUrl: './book-list.component.css'
})
export class BookListComponent {
  book : Book = {
    id: 1,
    title: 'Angular 2 Development with TypeScript',
    author: 'Yakov'
  };
}
