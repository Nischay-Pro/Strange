Imports System.Runtime.InteropServices

Public Class Form1
    Dim hgloballist As New List(Of IntPtr)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hglobal As IntPtr
        hglobal = Marshal.AllocHGlobal(10485760)
        hgloballist.Add(hglobal)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each Item As IntPtr In hgloballist
            Marshal.FreeHGlobal(Item)
        Next
    End Sub
End Class
