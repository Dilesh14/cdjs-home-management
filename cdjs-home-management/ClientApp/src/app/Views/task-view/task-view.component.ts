import { Component, OnInit } from '@angular/core';
import { TaskRequest } from "../../models/httpModels/TaskRequest"
import { RequestServices} from "../../services/requestServices"
import { MatSnackBar } from '@angular/material/snack-bar';
@Component({
  selector: 'app-task-view',
  templateUrl: './task-view.component.html',
  styleUrls: ['./task-view.component.css']
})
export class TaskViewComponent implements OnInit {
    private taskModel: TaskRequest;
    constructor(private _reqService: RequestServices, private _snackbar: MatSnackBar) {
        this.taskModel = new TaskRequest();
    }

    ngOnInit() {
      //Call the database..
        //send the user Id to get the Task of the user from the
        //server.
        //[for me] decide whether to show all the users task or just the
        //signed in users task
    }
    private taskResponse: boolean;
    createTask() {
        this._reqService.createUsersTask(this.taskModel).subscribe(result => {
            this.taskResponse = result;
        }, err => { }, () => {
                if (this.taskResponse) {
                    this._snackbar.open("Registered Task!!", "Okay", {
                        duration: 3000,
                    });
                }
                else {
                    this._snackbar.open("Failed!!", "Okay", {
                        duration: 3000,
                    });
                }
        });
    }

}
