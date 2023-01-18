﻿using RMA_2022_23_Student_App.Models;
using RMA_2022_23_Student_App;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RMA_2022_23_Student_App.ViewModels
{
    public class IntroScreenViewModel : BaseViewModel
    {
        private string _buttonText = "NEXT";
        public string ButtonText
        {
            get => _buttonText;
            set => SetProperty(ref _buttonText, value);
        }

        private int _position;
        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value, onChanged: (() =>
            {
                if (value == IntroScreens.Count - 1)
                {
                    ButtonText = "START";
                }
                else
                {
                    ButtonText = "NEXT";
                }
            }));
        }

        public ObservableCollection<IntroScreenModels> IntroScreens { get; set; } = new ObservableCollection<IntroScreenModels>();

        public IntroScreenViewModel()
        {
            IntroScreens.Add(new IntroScreenModels
            {
                IntroTitle = "Welcome To StudentApp",
                IntroDescription = "Enjoy the captivating process of online education in a place and at a time of your choice",
                IntroImage = "stack"
            });

            IntroScreens.Add(new IntroScreenModels
            {
                IntroTitle = "Anytime, Anywhere",
                IntroDescription = "Now you can check homework anytime right from mobile",
                IntroImage = "elearning"
            });

            IntroScreens.Add(new IntroScreenModels
            {
                IntroTitle = "Ready to Find A Course",
                IntroDescription = "Join our online school that will help you learn the cutting-edge skills to scale new heights in your creative career.",
                IntroImage = "homew"
            });
        }

        public ICommand NextCommand => new Command(async () =>
        {
            if (Position >= IntroScreens.Count - 1)
            {
                await AppShell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
            else
            {
                Position += 1;
            }
        });
    }
}
