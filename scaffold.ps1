$project = "Wms.Data"
$connectionString = "Data Source= 107.151.3.34\MSSQLSERVER2016;Initial Catalog=WmsSystemDb;user id=freefixe_filip;password=Qwerty1$$;"


foreach ($proj in Get-Project) {
	if ($proj.ProjectName -ne $project) {
		Write-Host "ERROR: Project $project not selected as default." -BackgroundColor DarkRed -ForegroundColor White
		Exit
	}
}

Scaffold-DbContext $connectionString Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -Context "DataContext" -force