import { Component } from '@angular/core';
import { AlertifyOptions, AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {

  constructor(private alertify: AlertifyService) {

  }
  ngOnInit(): void {
  }

  tikla() {
    this.alertify.message("dflgdgdnfg", {
      messageType: MessageType.Success,
      delay: 5,
      isDismissOthers: true,
      position: Position.BottomCenter
    })
  }
}
