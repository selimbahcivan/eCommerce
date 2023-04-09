import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './admin/admincomponents/dashboard/dashboard.component';
import { LayoutComponent } from './admin/layout/layout.component';
import { HomeComponent } from './ui/uicomponents/home/home.component';

const routes: Routes = [
  {
    path: "admin", component: LayoutComponent, children: [
      { path: "", component: DashboardComponent },
      { path: "customers", loadChildren: () => import("./admin/admincomponents/customers/customers.module").then(module => module.CustomersModule) },
      { path: "products", loadChildren: () => import("./admin/admincomponents/products/products.module").then(module => module.ProductsModule) },
      { path: "orders", loadChildren: () => import("./admin/admincomponents/orders/orders.module").then(module => module.OrdersModule) },
      // { path: "dashboard", loadChildren: () => import("./admin/admincomponents/dashboard/dashboard.module").then(module => module.DashboardModule) }
    ]
  },
  { path: "", component: HomeComponent },
  { path: "basket", loadChildren: () => import("./ui/uicomponents/basket/basket.module").then(module => module.BasketModule) },
  { path: "products", loadChildren: () => import("./ui/uicomponents/products/products.module").then(module => module.ProductsModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
