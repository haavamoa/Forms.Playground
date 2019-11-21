using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Forms.Playground.MountainApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MountainPage : ContentPage
    {
        private bool m_registerIsOpen;
        private bool m_isRegistering;
        private bool m_isNotRotating = true;

        public MountainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            IsRegistering = false;
            content.Content = new MountainsList();
        }

        public bool IsRegistering
        {
            get => m_isRegistering;
            set
            {
                m_isRegistering = value; 
                OnPropertyChanged();
            }
        }

        private async void ProfileImage_OnClicked(object sender, EventArgs e)
        {
            var length = (uint)400;
            if (profileImage.RotationY == 0)
            {
                await profileImage.RotateYTo(-180, length);
            }
            else
            {
                await profileImage.RotateYTo(0, length);
            }
        }

        private async void Register_OnClicked(object sender, EventArgs e)
        {
            if (contentFrame.RotationY != 0) return;
            IsNotRotating = false;
            await contentFrame.RotateYTo(-180);
            contentFrame.RotationY = 0;
            IsNotRotating = true;
            if (!IsRegistering)
            {
                actionButton.Text = "Done";
                IsRegistering = true;
            }
            else
            {
                m_registerIsOpen = true;
                actionButton.Text = "Register";
                IsRegistering = false;
            }
        }

        public bool IsNotRotating
        {
            get => m_isNotRotating;
            set
            {
                m_isNotRotating = value;
                OnPropertyChanged();
            } 
        }
    }
}
