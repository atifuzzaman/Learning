import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CatapiService {

  constructor(private client:HttpClient) { }

  getCatFacts(){
    return this.client.get("https://cat-fact.herokuapp.com/facts/random?animal_type=cat&amount=1")
  }

}
