import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Welcome } from "./welcome/welcome";
import { Home } from "./home/home";

@Component({
  standalone: true,
  selector: 'app-root',
  imports: [RouterOutlet, Welcome],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('my-first-app');
}
