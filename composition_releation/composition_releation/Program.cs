// See https://aka.ms/new-console-template for more information

HOD obj = new HOD("Khalid Khan","Control Enviroment Polution","Dummy Text",700000);
obj.WorkingonProject("Good");
obj.WorkingonProject("Good");
obj.WorkingonProject("Bad");
obj.HODProjectDetails();
class Project
{
    public string ProjectTitle;
    public string ProjectDescription;
    public double ProjectCost;
    public double ProjectCompletion;

    public Project(string title, string desc,double cost)
    {
        ProjectTitle = title;
        ProjectDescription = desc;
        ProjectCost = cost;
    }
    public void ProjectSuccess(HOD hod)
    {
        this.ProjectCompletion += 1;
        hod.Performance += 1;
    }
    public void ProjectFail (HOD hod)
    {
        hod.Performance -= 1;
    }
}
class HOD
{
    public string Name;
    public int Performance = 0;
    Project project;
    public HOD(string name, string title, string desc, double cost)
    {
        Name = name;
        project = new Project(title,desc,cost);
    }

    public void WorkingonProject(string value) 
    {
        if (value == "Good")
        {
            project.ProjectSuccess(this);
        }
        else
        {
            project.ProjectFail(this);
        }
    }
    public void HODProjectDetails()
    {
        Console.WriteLine("Project Title: "+project.ProjectTitle);
        Console.WriteLine("Project Description: "+project.ProjectDescription);
        Console.WriteLine("Project Cost: "+project.ProjectCost);
        Console.WriteLine("Project Creator Name: "+this.Name);
        Console.WriteLine("Project Creator Performance: "+this.Performance);
        Console.WriteLine("Total Persentage of project Comletion: "+project.ProjectCompletion);
    }
}