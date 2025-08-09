import { Component } from '@angular/core';
import { AppChildComponent } from './components/app-child/app-child.component';

@Component({
  standalone: true,
  selector: 'app-home',
  imports: [AppChildComponent],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {
  parentMessage = 'Hello from Home (parent)!';

}
