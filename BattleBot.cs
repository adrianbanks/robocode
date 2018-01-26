using System.Drawing;
using Robocode;

namespace ANB.BattleBot
{
    public class DestructoBot : Robot
    {
        public override void OnWin(WinEvent evnt)
        {
            for (int i = 0; i < 1080 / 30; i++)
            {
                TurnLeft(30);
                TurnGunRight(30);
            }
        }

        public override void Run()
        {
            BodyColor = Color.GreenYellow;
            GunColor = Color.CornflowerBlue;
            BulletColor = Color.Yellow;
            RadarColor = Color.OrangeRed;
            ScanColor = Color.Red;
            
            Back(300);
            TurnLeft(Heading - 90);
            //TurnGunRight(90);

            while (true)
            {
                Ahead(150);
                TurnRight(15);
                TurnGunLeft(45);
                Ahead(90);
                TurnGunLeft(45);
                TurnRight(15);
                TurnGunLeft(45);
                Back(300);
                TurnGunLeft(45);
                TurnRight(10);
            }                
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            Fire(1);
            Fire(1);
        }
    }
}