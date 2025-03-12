import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Chat.Client';
  date = new Date();

  time = `${this.date.getHours()} : ${this.date.getMinutes()}`
}
