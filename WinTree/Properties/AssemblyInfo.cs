using System.Reflection;
using System.Runtime.InteropServices;

using Xlfdll;

// アセンブリに関する一般的な情報は、次の方法で制御されます
// 制御されます。アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更します。
[assembly: AssemblyTitle("WinTree")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Xlfdll Workstation")]
[assembly: AssemblyProduct("WinTree")]
[assembly: AssemblyCopyright("© 2025 Xlfdll Workstation")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ComVisible を false に設定すると、このアセンブリ内の型は COM コンポーネントから
// 参照できなくなります。COM からこのアセンブリ内の型にアクセスする必要がある場合は、
// その型の ComVisible 属性を true に設定してください。
[assembly: ComVisible(false)]

// このプロジェクトが COM に公開される場合、次の GUID が typelib の ID になります
[assembly: Guid("e10ae97a-8e87-4ab6-9e2b-96ad852d5545")]

// アセンブリのバージョン情報は、以下の 4 つの値で構成されています:
//
//      メジャー バージョン
//      マイナー バージョン
//      ビルド番号
//      リビジョン
//
[assembly: AssemblyVersion("1.0." + BuildInfo.Build)]