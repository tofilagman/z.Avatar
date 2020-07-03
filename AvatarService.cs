using z.Avatar.BrushGenerators;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using z.Avatar.Managers;

namespace z.Avatar
{
    public class AvatarService : IAvatarService
    {
        private static Color[] Colors = new Color[] {
           ColorManager.FromHex("#2980b9"),
           ColorManager.FromHex("#3498db"),
           ColorManager.FromHex("#8e44ad"),
           ColorManager.FromHex("#9b59b6"),
           ColorManager.FromHex("#d35400"),
           ColorManager.FromHex("#e67e22"),
           ColorManager.FromHex("#c0392b"),
           ColorManager.FromHex("#e74c3c"),
           ColorManager.FromHex("#16a085"),
           ColorManager.FromHex("#7f8c8d"),
        };

        private IconGenerator Init()
        {
            IconGenerator.DefaultBlockGeneratorsConfig = IconGenerator.ExtendedBlockGeneratorsConfig;
            Random oRandom = new Random();

            int iNumber = oRandom.Next(0, Colors.Length - 1);

            IconGenerator.DefaultBrushGeneratorConfig = new StaticColorBrushGenerator(Colors[iNumber]);

            return new IconGenerator();
        }

        public void AddRandomColors(params Color[] colors)
        {
            var hn = Colors.Length;
            Array.Resize(ref Colors, Colors.Length + colors.Length);

            var index = 0;
            for (var i = hn; i < Colors.Length; i++)
            {
                Colors[i] = colors[index];
                index++;
            }
        }

        public Image Generate(string Text) => Init().Create(Text);

        public Image Generate(string Text, Size size) => Init().Create(Text, size);

        public Image Generate(byte[] value) => Init().Create(value);

        public Image Generate(byte[] value, Size size) => Init().Create(value, size);

        public string ConvertImagetoBase64(Image img)
        {
            using (MemoryStream m = new MemoryStream())
            {
                img.Save(m, ImageFormat.Png);
                byte[] imageBytes = m.ToArray();

                string base64String = Convert.ToBase64String(imageBytes);
                return $"data:image/png;base64,{ base64String }";
            }
        } 
    }
}
