import { Component, OnInit } from '@angular/core';
import { CatapiService } from '../catapi.service';

@Component({
  selector: 'app-externalservice',
  standalone: true,
  imports: [],
  templateUrl: './externalservice.component.html',
  styleUrl: './externalservice.component.css'
})

export class ExternalserviceComponent implements OnInit{

  data:any = { "updatedAt":null, "text":'' }

  constructor(public catService:CatapiService){}

  ngOnInit(): void {
    this.catService.getCatFacts().subscribe((res:any)=>{
      console.log(res);
      this.data.updatedAt = res.updatedAt;
      this.data.text = res.text;
    })
  }
  
}
