using Playground.Common.Base;
using Playground.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Vm = Playground.Features.Auth.AuthViewModel;
using static Xamarin.Forms.Markup.GridRowsColumns;

namespace Playground.Features.Auth
{
    public sealed class AuthPage : ContentPageBase<Vm>
    {
        public AuthPage() => Build();

        private void Build()
        {
            InitializeViewModel();
            
            Content = new Grid {
                    RowDefinitions = Rows.Define(Star, Auto, Auto, Auto, Auto, Auto, Star),
                    Children = {
                        new Label { TextColor = Color.Black }
                            .Row(0)
                            .Center()
                            .Bind(nameof(Vm.LoginText)),
                        new Button { Text = Localization.ButtonSignInAnonymously, TextColor = Color.Black }
                            .Row(1)
                            .FillHorizontal()
                            .Top()
                            .Bind(nameof(Vm.SignInAnonymouslyCommand)),
                        new Button { Text = Localization.ButtonSignInWithEmail, TextColor = Color.Black }
                            .Row(2)
                            .FillHorizontal()
                            .Top()
                            .Bind(nameof(Vm.SignInWithEmailCommand)),
                        new Button { Text = Localization.ButtonSignInWithEmailLink, TextColor = Color.Black }
                            .Row(3)
                            .FillHorizontal()
                            .Top()
                            .Bind(nameof(Vm.SignInWithEmailLinkCommand)),
                        new Button { Text = Localization.ButtonSignInWithGoogle, TextColor = Color.Black }
                            .Row(4)
                            .FillHorizontal()
                            .Top()
                            .Bind(nameof(Vm.SignInWithGoogleCommand)),
                        new Button { Text = Localization.ButtonSignInWithFacebook, TextColor = Color.Black }
                            .Row(5)
                            .FillHorizontal()
                            .Top()
                            .Bind(nameof(Vm.SignInWithFacebookCommand)),
                        new Button { Text = Localization.ButtonSignInWithPhoneNumber, TextColor = Color.Black }
                            .Row(6)
                            .FillHorizontal()
                            .Top()
                            .Bind(nameof(Vm.SignInWithPhoneNumberCommand)),
                        new Button { Text = Localization.ButtonSignOut, TextColor = Color.Black }
                            .Row(7)
                            .FillHorizontal()
                            .Bottom()
                            .Bind(nameof(Vm.SignOutCommand))
                    }
                }
                .Margin(24);
        }
    }
}