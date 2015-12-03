using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Novacode;
using System.Drawing;


namespace Problem_5.Word_Document_Generator
{
    class Program
    {
        private const int DEFAULT_TEXT_SIZE = 12;
        static void Main(string[] args)
        {
            using (DocX document = DocX.Create("../../SoftUniGame.docx"))
            {
                Paragraph title = document.InsertParagraph();
                title.AppendLine("SoftUni OOP Game Contest").Bold().FontSize(30);
                title.Alignment = Alignment.center;

                Novacode.Image imageGame = document.AddImage("../../rpg-game.png");
                Paragraph pictureParagraph = document.InsertParagraph("", false);
                Picture game = imageGame.CreatePicture(250, 600);
                pictureParagraph.InsertPicture(game);

                Paragraph text = document.InsertParagraph();
                text.FontSize(13);
                text.AppendLine();
                text.Append("SoftUni is organizing a contest for the best ").FontSize(DEFAULT_TEXT_SIZE);
                text.Append("role playing game").Bold().FontSize(DEFAULT_TEXT_SIZE);
                text.Append(" from the OOP teamwork\r\n projects. The winning teams will receive a ").FontSize(DEFAULT_TEXT_SIZE);
                text.Append("grand prize").Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(DEFAULT_TEXT_SIZE);
                text.Append("!\r\nThe game should be:").FontSize(DEFAULT_TEXT_SIZE);
                

                List bullets = document.AddList(null,0,ListItemType.Bulleted);
                document.AddListItem(bullets, "Properly structured and follow all good OOP practices");
                document.AddListItem(bullets, "Awesome");
                document.AddListItem(bullets, "..Very Awesome");
                document.InsertList(bullets);
                document.InsertParagraph("\r\n");

                Table table = document.AddTable(4, 3);
                
                
                table.Alignment = Alignment.center;
                
                table.Rows[0].Cells[0].Paragraphs.First().Append("Team").Bold().Color(Color.White);
                table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
                table.Rows[0].Cells[0].FillColor = Color.CornflowerBlue;
                table.Rows[0].Cells[1].Paragraphs.First().Append("Game").Bold().Color(Color.White);
                table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
                table.Rows[0].Cells[1].FillColor = Color.CornflowerBlue;
                table.Rows[0].Cells[2].Paragraphs.First().Append("Points").Bold().Color(Color.White);
                table.Rows[0].Cells[2].Paragraphs.First().Alignment = Alignment.center;
                table.Rows[0].Cells[2].FillColor = Color.CornflowerBlue;

                for (int i = 1; i < 4; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        table.Rows[i].Cells[j].Paragraphs.First().Append("-");
                        table.Rows[i].Cells[j].Paragraphs.First().Alignment = Alignment.center;
                    }
                }

                table.Rows[0].Cells.ForEach(c => c.Width = 300);
                table.Rows[1].Cells.ForEach(c => c.Width = 300);
                table.Rows[2].Cells.ForEach(c => c.Width = 300);
                document.InsertTable(table);

                Paragraph lastText = document.InsertParagraph();
                lastText.AppendLine();
                lastText.Append("The top 3 teams will receive a ").FontSize(DEFAULT_TEXT_SIZE);
                lastText.Append("SPECTACULAR").Bold().FontSize(13);
                lastText.Append(" prize: \r\n").FontSize(DEFAULT_TEXT_SIZE);
                lastText.Append("A HANDSHAKE FROM NAKOV")
                    .Bold()
                    .UnderlineStyle(UnderlineStyle.thick).FontSize(17)
                    .Color(Color.MidnightBlue);
                lastText.Alignment = Alignment.center;
                

             

                document.Save();
            }
        }
    }
}
