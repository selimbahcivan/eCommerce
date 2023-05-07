import { Component } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';
import { AlertifyOptions, AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent extends BaseComponent {

  constructor(private alertify: AlertifyService, spinner: NgxSpinnerService) {
    super(spinner);
  }
  ngOnInit() {
    this.showSpinner(SpinnerType.BallTrianglePath);
  }
}
