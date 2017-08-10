FROM microsoft/iis
RUN ["powershell.exe", "Install-WindowsFeature NET-Framework-45-ASPNET"]
RUN ["powershell.exe", "Install-WindowsFeature Web-Asp-Net45"]
ADD web-app/ c:\\web-app
EXPOSE 8081
RUN powershell New-Website -Name 'web-app' -Port 8081 -PhysicalPath 'c:\web-app' -ApplicationPool '.NET v4.5'
ENTRYPOINT powershell
