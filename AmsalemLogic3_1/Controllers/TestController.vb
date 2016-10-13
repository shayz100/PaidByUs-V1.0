Imports System.Web.Mvc
Imports AmsalemLogic.NewLogic

Namespace Controllers
    Public Class TestController
        Inherits Controller

        Function MyView() As ActionResult
            Dim TestClass = New TestClass()
            Return View(TestClass)
        End Function
    End Class
End Namespace