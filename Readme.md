
About
-----

run-hidden is a simple command line app that allows to run
console apps like powershell with hidden console window.

Example command line
--------------------

```PowerShell
run-hidden powershell -command calc.exe
```


Note
----

Even though powershell.exe (v5.1) and pwsh.exe (v7) give the same
result when outputting `Get-ExecutionPolicy -List`, I experienced
a situation where pwsh.exe worked and powershell.exe returned
a policy restriction related error. It was solved by using pwsh.exe
instead of powershell.exe, alternativly using `-ExecutionPolicy Bypass`
would probably also work.


Related apps
------------

Find a list of related apps:

https://stax76.github.io/frankskare
