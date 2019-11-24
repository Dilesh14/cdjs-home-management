import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-task-view',
  templateUrl: './task-view.component.html',
  styleUrls: ['./task-view.component.css']
})
export class TaskViewComponent implements OnInit {

  constructor() { }

    ngOnInit() {
      //Call the database..
        //send the user Id to get the Task of the user from the
        //server.
        //[for me] decide whether to show all the users task or just the
        //signed in users task
  }

}
