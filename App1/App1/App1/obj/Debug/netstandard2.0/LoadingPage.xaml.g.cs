//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("App1.LoadingPage.xaml", "LoadingPage.xaml", typeof(global::App1.LoadingPage))]

namespace App1 {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("LoadingPage.xaml")]
    public partial class LoadingPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::App1.ViewModel.LoadingViewModel vm;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Image BannerImg;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ProgressBar MainProgressBar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(LoadingPage));
            vm = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::App1.ViewModel.LoadingViewModel>(this, "vm");
            BannerImg = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Image>(this, "BannerImg");
            MainProgressBar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ProgressBar>(this, "MainProgressBar");
        }
    }
}
