// Copyright (C) Microsoft Corporation. All rights reserved.

using System;

namespace FizzyoMonoGame
{
    class GameConstants
    {
        //camera constants
        public const float NearClip = 1.0f;
        public const float FarClip = 1000.0f;
        public const float ViewAngle = 45.0f;

        //player constants
        public const float Velocity = 0.75f;
        public const float TurnSpeed = 0.025f;
        public const int MaxRange = 98;
        public const float MoveCost = 0.3f;
        public const float MaxPower = 100;
        public const float Smoothing = 0.03f;


        //general
        public const int MaxRangeTerrain = 98;
        public const int NumBarriers = 40;
        public const int NumFuelCells = 12;
        public const int MinDistance = 10;
        public const int MaxDistance = 90;
        public static readonly TimeSpan RoundTime = TimeSpan.FromSeconds(30.25);
        public const string StrTimeRemaining = "Time Remaining: ";
        public const string StrCellsFound = "Fuel Cells Retrieved: ";
        public const string StrGameWon = "Game Won !";
        public const string StrGameLost = "Game Lost !";
        public const string StrPlayAgain = 
            "Press Enter/Start to play again or Esc/Back to quit";
        public const string StrInstructions1 = 
            "Retrieve all Fuel Cells before time runs out.   Use your Fizzyo to charge up the ship";
        public const string StrInstructions2 = 
            "Control ship using keyboard (A, D, W, S) or the left thumbstick.";
        public const string StrInstructions3 =
            "Can only move when the ship is charged\nTime also only runs when you are moving";

        //bounding sphere scaling factors
        public const float FuelCarrierBoundingSphereFactor = .8f;
        public const float FuelCellBoundingSphereFactor = .5f;
        public const float BarrierBoundingSphereFactor = .7f;
    }
}
