Imports DevExpress.XtraMap
Imports System
Imports System.Windows.Forms
Namespace SvgDataAdapterSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#SvgFileDataAdapter"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim baseUri As New Uri(System.Reflection.Assembly.GetExecutingAssembly().Location)
            map.Layers.Add(New VectorItemsLayer With { _
                .Data = New SvgFileDataAdapter With {.FileUri = New Uri(baseUri, "..\..\Data\countries.svg")} _
            })
        End Sub
        #End Region ' #SvgFileDataAdapter
    End Class
End Namespace
