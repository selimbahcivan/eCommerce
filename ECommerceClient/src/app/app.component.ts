import { Component } from '@angular/core';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from './services/ui/custom-toastr.service';
declare var $: any

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ECommerceClient';

  constructor(private toastrService: CustomToastrService) {
    // toastrService.message("Merhabaaaa", "Selim", {messageType : ToastrMessageType.Success, position: ToastrPosition.BottomCenter});
    // toastrService.message("123", "Selim", {messageType :ToastrMessageType.Info,position: ToastrPosition.TopFullWidth});


  }
}

$.get("https://localhost:44385/api/products",data => console.log(data[0]))

// $(document).ready(() => {
//   alert("sjnskfgdfkjg")
// })
