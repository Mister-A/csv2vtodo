# csv2vtodo
Converts CSV task list (such as an exported task report from Workast) to an .ics VCALENDAR VTODO task list format for importing into open calendars and task list such as Google and Nextcloud.

Supports lists and sub-tasks.

Copyright 2022 Andrew Aldridge

## How to use 
Initial usecase was to export task lists from Workast for import into Nextcloud tasks.

* Export a csv for each of your Workast Spaces by generating a report as shown here: https://www.workast.com/help/articles/61000165222/
* Use csv2vtodo to convert each Space to an ics task list
* Import ics task list to your Calendar/Task application, in testing I used eM Client:
  * In eM Client add a Calendar only account connected to your DAV server 
  * Manually create a task list for each of the Workast Spaces you wish to import on your CalDAV server (Nextcloud in my case)
  * Make sure those are visible in eM Client by doing a Refresh in eM Client
  * In eM Client Select Menu > File > Import ...
    * Choose Files > iCalendar (.ics) and click Next
    * Browse for the .ics file csv2vtodo created for the Space you wish to import
    * Select folder and choose the Task list you created for this Space
    * Click Finish to go ahead and import the tasks

Workast Lists will be created as top-level tasks.
Workast Tasks will be placed within those lists as sub-tasks.
If your Workast Tasks contained Sub Tasks those will be created as sub-sub-tasks.
    



