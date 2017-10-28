;#DropDB FinacoreEasyTest

#Application Finacore.Win
#Application Finacore.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef Finacore.Win

*Action About...
 
*Action OK

#EndIf

#IfDef Finacore.Web
*Action Navigation(My Details)
#EndIf
