Imports System.Web.Mvc
Imports AmsalemLogic.NewLogic
Imports AmsalemLogic.VBClasses

Namespace Controllers
    Public Class TestController
        Inherits Controller

        Function MyView() As ActionResult
            Dim TestClass = New TestClass()
            Return View(TestClass)
        End Function

        sub PermissionExample() 
            Dim user = ClassUsers.GetCurrentUser()
            Dim userPermission = New Administration.UserPermissionHandler()
            Dim permission = userPermission.IsActionAllowed(user.PermissionGroup, "Watch Financials", "")
            If (Not permission) Then
                Throw New ApplicationException(userPermission.UNAUTHORIZED_MESSAGE)
            End If
            'TODO- Do Actions 
        End Sub
    End Class
End Namespace