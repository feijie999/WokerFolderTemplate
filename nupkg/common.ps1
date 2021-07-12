# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of solutions
$solutions = (
    "aspnet-core",
    "modules/project"
)

# List of projects
$projects = (
   "aspnet-core/src/CompanyName.ProjectName.Application",
   "aspnet-core/modules/project/src/CompanyName.ProjectName.Project.Application",
   "aspnet-core/modules/project/src/CompanyName.ProjectName.Project.Application.Contracts",
   "aspnet-core/modules/project/src/CompanyName.ProjectName.Project.Domain",
   "aspnet-core/modules/project/src/CompanyName.ProjectName.Project.Domain.Shared",
   "aspnet-core/modules/project/src/CompanyName.ProjectName.Project.EntityFrameworkCore",
   "aspnet-core/modules/project/src/CompanyName.ProjectName.Project.HttpApi",
   "aspnet-core/modules/project/src/CompanyName.ProjectName.Project.HttpApi.Client"
)