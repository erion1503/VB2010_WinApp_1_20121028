﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.18010
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'このクラスは StronglyTypedResourceBuilder クラスが ResGen
    'または Visual Studio のようなツールを使用して自動生成されました。
    'メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    'ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    '''<summary>
    '''  ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("VB2010_WinApp_1_20121028.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        '''  現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property maru1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("maru1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property maru2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("maru2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property masu0() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("masu0", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property かがみ_黒() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("かがみ_黒", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property つかさ_白() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("つかさ_白", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property なっとくいかねぇ() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("なっとくいかねぇ", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        '''</summary>
        Friend ReadOnly Property バルサミコ酢() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("バルサミコ酢", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
