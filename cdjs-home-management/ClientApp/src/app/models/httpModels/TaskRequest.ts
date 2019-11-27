import { task } from "../Task"
import {Credential } from"../credential"
export class TaskRequest {
    tasks: task;
    user: Credential;
}
