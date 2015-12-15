using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using Novacode;
using Image = Novacode.Image;

namespace _05.WordDocumentGenerator
{
    class DocX
    {
        static void Main()
        {
            string fileName = @"../../DocXExample.docx";

            var doc = Novacode.DocX.Create(fileName);

            string headlineText = "SoftUni OOP Game Contest";

            var headLineFormat = new Formatting();
            headLineFormat.FontFamily = new FontFamily("Arial Black");
            headLineFormat.Size = 18D;

            Paragraph title = doc.InsertParagraph(headlineText, false, headLineFormat);
            title.Alignment = Alignment.center;

            Image imageGame = doc.AddImage("../../rpg-game.png");
            Paragraph pictureParagraph = doc.InsertParagraph("", false);
            Picture game = imageGame.CreatePicture(250, 600);
            pictureParagraph.InsertPicture(game);

            Paragraph paragraphOne = doc.InsertParagraph();
            paragraphOne.AppendLine();
            paragraphOne.Append("SoftUni is organizing a contest for the best ");
            paragraphOne.Append("role playing game ").Bold();
            paragraphOne.Append("from the OOP teamwork projects. The winning teams will receive a ");
            paragraphOne.Append("grand prize!").Bold().UnderlineStyle(UnderlineStyle.singleLine);
            paragraphOne.AppendLine();

            List bullets = doc.AddList(null, 0, ListItemType.Bulleted);
            doc.AddListItem(bullets, "Properly structured and follow all good OOP practices");
            doc.AddListItem(bullets, "Awesome");
            doc.AddListItem(bullets, "..Very Awesome");
            doc.InsertList(bullets);

            doc.InsertParagraph(paragraphOne);

            Table table = doc.AddTable(4, 3);
            table.Rows[0].Cells[0].Paragraphs.First().Append("Team").Color(Color.White).Bold().Alignment = Alignment.center;
            table.Rows[0].Cells[0].FillColor = Color.RoyalBlue;
            table.Rows[0].Cells[1].Paragraphs.First().Append("Game").Color(Color.White).Bold().Alignment = Alignment.center;
            table.Rows[0].Cells[1].FillColor = Color.RoyalBlue;
            table.Rows[0].Cells[2].Paragraphs.First().Append("Points").Color(Color.White).Bold().Alignment = Alignment.center;
            table.Rows[0].Cells[2].FillColor = Color.RoyalBlue;

            for (int i = 1; i < table.RowCount; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    table.Rows[i].Cells[j].Paragraphs.First().Append("-").Alignment = Alignment.center;
                }
            }

            table.Alignment = Alignment.center;

            doc.InsertTable(table);

            Paragraph finalParagraph = doc.InsertParagraph();
            finalParagraph.AppendLine();
            finalParagraph.Append("The top 3 teams will receive a ");
            finalParagraph.Append("SPECTACULAR").Bold().FontSize(12);
            finalParagraph.Append(string.Format(" prize: {0}", Environment.NewLine));
            finalParagraph.Append("A HANDSHAKE FROM NAKOV").FontSize(18).Color(Color.RoyalBlue).UnderlineStyle(UnderlineStyle.singleLine).Font(new FontFamily("Arial Black"));

            finalParagraph.Alignment = Alignment.center;
            
            doc.Save();
            
            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
