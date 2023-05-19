namespace BusinessLayer.BusinessModels;

public class ApplicationPermission
{
    public int ApplicationId { get; set; }
    public string ApplicationName { get; set; } = string.Empty;
    public List<ApplicationPermission> ChildApplications { get; set; } = new();
    public List<ActionPermission> Actions { get; set; } = new();
}