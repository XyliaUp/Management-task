@ECHO off

call "D:\Visual Studio\Common7\Tools\VsDevCmd"

ECHO.
@ECHO ON
sqlmetal /server:127.0.0.1,1433 /database:ssms  /namespace:TMS.LTS /user:sa /password:123456 /code:"%TMS%" /views /functions /sprocs /language:c# /context:LTSBase
@ECHO OFF
ECHO.
ECHO Done...
ECHO.


