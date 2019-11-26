import { Component, OnInit } from '@angular/core';
import { task} from '../../models/Task'

@Component({
  selector: 'app-task-view',
  templateUrl: './task-view.component.html',
  styleUrls: ['./task-view.component.css']
})
export class TaskViewComponent implements OnInit {
    private taskModel: task;
    constructor() {
        this.taskModel = new task();
    }

    ngOnInit() {
      //Call the database..
        //send the user Id to get the Task of the user from the
        //server.
        //[for me] decide whether to show all the users task or just the
        //signed in users task
    }


}
