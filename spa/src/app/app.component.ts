import { Component } from '@angular/core';
import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Connecting...';

  constructor(private service: AppService) {
  }

  ngOnInit() {
    this.service.tryConnect().subscribe((response) => {
      this.title = response.state;
    })
  }
}
