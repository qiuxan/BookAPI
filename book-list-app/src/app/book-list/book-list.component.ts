import { Component } from '@angular/core';
import { Book } from '../book';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-book-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './book-list.component.html',
  styleUrl: './book-list.component.css'
})
export class BookListComponent {
  books : Book[] =[
    {
    id: 1,
    title: 'Angular 2 Development with TypeScript',
    author: 'Yakov'
    },
    {
    id: 2,
    title: 'Pro Angular',
    author: 'Adam Freeman'
    },
    
  ]; 
}
