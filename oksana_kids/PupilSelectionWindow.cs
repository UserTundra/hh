using oksana_kids.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace oksana_kids
{
    public partial class PupilSelectionWindow : Form
    {
        bd_kidsEntities1 bd = new bd_kidsEntities1();
        public string currentTest;

        Dictionary<int, string> speakCount = new Dictionary<int, string>();

        private void fillDictionary()
        {
            speakCount.Add(1, "первый");
            speakCount.Add(2, "второй");
            speakCount.Add(3, "третий");
            speakCount.Add(4, "четвертый");
            speakCount.Add(5, "пятый");
            speakCount.Add(6, "шестой");
            speakCount.Add(7, "седьмой");
            speakCount.Add(8, "восьмой");
            speakCount.Add(9, "девятый");
            speakCount.Add(10, "десятый");
            speakCount.Add(11, "одиннадцатый");
            speakCount.Add(12, "двенадцатый");
            speakCount.Add(13, "тринадцатый");
            speakCount.Add(14, "четырнадцатый");
            speakCount.Add(15, "пятнадцатый");
            speakCount.Add(16, "шестнадцатый");
            speakCount.Add(17, "семнадцатый");
            speakCount.Add(18, "восемнадцатый");
            speakCount.Add(19, "девятнадцатый");
            speakCount.Add(20, "двадцатый");
            speakCount.Add(21, "двадцать первый");
            speakCount.Add(22, "двадцать второй");
            speakCount.Add(23, "двадцать третий");
            speakCount.Add(24, "двадцать четвертый");
        }

        public PupilSelectionWindow()
        {
            InitializeComponent();
            getTestList();
        }

        public void setSpeech(string text)
        {
            SpeechSynthesizer speechSynth = new SpeechSynthesizer(); 

            speechSynth.Volume = 100; 
            speechSynth.Speak(text); 
                       
            speechSynth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen); 
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fillDictionary();
        }

        public void setTestId()
        {

        }

        
        private void getTestList()
        {
            var linq = from a in bd.T02_tests
                       select new
                       {
                           test = a.name_test
                       };

            foreach (var item in linq)
            {
                testList.Items.Add(item.test);
            }
        }

        private void getTestInfo()
        {
            long test_id = getTestID();

            try
            {
                var linq = (from a in bd.T02_tests
                            join c in bd.B05_testing_task_modules_to_tests on a.id_test equals c.id_test
                            join d in bd.R07_methodical_materials on a.id_method_material equals d.id_method_material
                            where a.id_test == test_id
                            select new
                            {
                                duration = a.max_passing_duration_sec/60,
                                material = d.description,
                                count = bd.B05_testing_task_modules_to_tests.Select(x => x.id_module).Count()
                            }).ToList();

                foreach (var item in linq)
                {
                    duration.Text = item.duration.ToString();
                    //countTZ.Text = item.count.ToString();
                    methodMaterial.Text = item.material.ToString();
                }

                var linq2 = (from a in bd.B05_testing_task_modules_to_tests
                             where a.id_test == test_id
                             group a by a.id_test into g
                             select new
                             {
                                 count = g.Count()
                             }).ToList();

                foreach (var item in linq2)
                {
                    countTZ.Text = item.count.ToString();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                AskToLeaveForm a = new AskToLeaveForm();
                a.Show();
            }
        }
        
        private void testList_DoubleClick(object sender, EventArgs e)
        {
            duration.Text = "";
            countTZ.Text = "";
            methodMaterial.Text = "";

            getTestInfo();
        }

        public string getTestName()
        {
            if (testList.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Выбери тест!");
                setSpeech("Выбери тест");
            }
            else
            {
                currentTest = testList.SelectedItem.ToString();
                testName.Text = currentTest;
            }
            

            if (testList.SelectedItem == null) return "";
            else return currentTest;
        }

        public long getTestID()
        {
            string test_name = getTestName();

            var linq0 = (from a in bd.T02_tests
                         where a.name_test == test_name
                         select new
                         {
                             id_test = a.id_test
                         }).ToList();

            long id_test = linq0.First().id_test;
            //testID = (int)id_test;

            return id_test;
        }

        public void getTasksFromTest()
        {
            int id_test = (int)getTestID();

            //var linq = from a in bd.B05_testing_task_modules_to_tests
            //           join b in bd.T03_testing_task_modules on a.id_module equals b.id_module
            //           join c in bd.T04_testing_tasks on b.id_task equals c.id_task
            //           where a.id_test == id_test
            //           select new
            //           {
            //               listTaskID = 
            //           }
        }

        public string wrongAnswerImagePath = "";
        public static long TestID;
        public static string dateBegin;
        public static string timeBegin;
        public static string timeEnd;
        public static int endTestingReason = 2;
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedTaskIdx = 0;
            selectedTaskIdx = this.testList.SelectedIndex;
            PupilSelectionWindow.dateBegin = DateTime.Today.ToShortDateString();
            PupilSelectionWindow.timeBegin = DateTime.Now.ToShortTimeString();

            TestID = selectedTaskIdx+1;
            List<List<SimplyTest>> lstTest = null;
            if(selectedTaskIdx == 17)
            {
                lstTest = getLastTest();
            }else if(selectedTaskIdx == 1)
            {
                lstTest = getSecondTest(); 
            }
            else
            {
                lstTest = getFirstTest();
            }
            setSpeech("Начать тестирование");

            int testID = (int)getTestID();
            //var attempts = new FileParser().IMages((int)this.getTestID());
            this.Hide();
            setSpeech("Тест " + speakCount[testID]);
            

            //var imageSwapper = new TestForm2(simplyQuestion, this);
            //imageSwapper.Show();
            var args = new TestFormsArgument(lstTest, this);
            int timeTest = 0;
            if (!int.TryParse(duration.Text, out timeTest))
                timeTest = 9999;
            else
                timeTest *= 60;
            
            var parent = new TestParent(args,timeTest,wrongAnswerImagePath);
            parent.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            setSpeech("Обучающий материал");
            string item = imageOrVideoDecider(getItemPath());
            if (item == "image")
            {
                Pictures p = new Pictures(getItemPath(), getDescription());
                p.Show();
            }
            else
            {
                Videos v = new Videos(getItemPath(), getDescription());
                v.Show();
            }
        }

        private string imageOrVideoDecider(string path)
        {
            string answer = "";
            Regex regex_image = new Regex(@".*[.](jpg|png|jpeg|gif|GIF|JPG|JPEG|PNG)");
            Regex regex_video = new Regex(@".*[.](dv|avi|mpeg|mov|dvd|flv|mp3|mp4|DV|AVI|MPEG|MOV|DVD|FLV|MP3|MP4)");

            if (regex_image.IsMatch(path))
                answer = "image";
            else answer = "video";

            return answer;
        }

        public string getItemPath()
        {
            int testID = (int)getTestID();
            string path = "";
            
            var linq = (from a in bd.T06_teaching_materials
                        join b in bd.T02_tests on a.id_teach_material equals b.id_teach_material
                        where b.id_test == testID
                        select new
                        {
                            pic = a.file_location,
                        }).ToList();

            foreach (var item in linq)
            {
                path = Path.GetFullPath(item.pic);
            }

            return path;
        }

        public string getDescription()
        {
            int testID = (int)getTestID();
            string description = "";

            var linq = (from a in bd.T06_teaching_materials
                        join b in bd.T02_tests on a.id_teach_material equals b.id_teach_material
                        where b.id_test == testID
                        select new
                        {
                            text = a.description
                        }).ToList();

            foreach (var item in linq)
            {
                description = item.text;
            }

            return description;
        }
        
        private void label4_Click(object sender, EventArgs e)
        {
            if (duration.Text != "")
            {
                setSpeech("Тест будет длиться");
                setSpeech(duration.Text + "минут");
            }
            
            Label label4 = sender as Label;

            if (label4 != null)
            {
                Clipboard.SetText(label4.Text, TextDataFormat.UnicodeText);
            }
        }
        
        private void zoomButton_Click(object sender, EventArgs e)
        {
            setSpeech("Экранная лупа");
            string s = Clipboard.GetText();
            Zoom z = new Zoom(s);
            z.Show();
            Clipboard.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (countTZ.Text != "")
            {
                setSpeech("В тесте будет");
                setSpeech(countTZ.Text + "заданий");
            }
            Label label5 = sender as Label;

            if (label5 != null)
            {
                Clipboard.SetText(label5.Text, TextDataFormat.UnicodeText);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Label label6 = sender as Label;

            if (label6 != null)
            {
                Clipboard.SetText(label6.Text, TextDataFormat.UnicodeText);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            setSpeech("Характеристики теста");
            Label label3 = sender as Label;

            if (label3 != null)
            {
                Clipboard.SetText(label3.Text, TextDataFormat.UnicodeText);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label label1 = sender as Label;

            if (label1 != null)
            {
                Clipboard.SetText(label1.Text, TextDataFormat.UnicodeText);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            setSpeech("Выбери тему тестирования");
            Label label2 = sender as Label;

            if (label2 != null)
            {
                Clipboard.SetText(label2.Text, TextDataFormat.UnicodeText);
            }
        }

        private void duration_Click(object sender, EventArgs e)
        {
            TextBox duration = sender as TextBox;

            if (duration != null)
            {
                Clipboard.SetText(duration.Text, TextDataFormat.UnicodeText);
            }
        }

        private void countTZ_Click(object sender, EventArgs e)
        {
            TextBox countTZ = sender as TextBox;

            if (countTZ != null)
            {
                Clipboard.SetText(countTZ.Text, TextDataFormat.UnicodeText);
            }
        }

        private void methodMaterial_Click(object sender, EventArgs e)
        {
            TextBox methodMaterial = sender as TextBox;

            if (methodMaterial != null)
            {
                Clipboard.SetText(methodMaterial.Text, TextDataFormat.UnicodeText);
            }
        }

        private void testList_Click(object sender, EventArgs e)
        {
            ListBox testList = sender as ListBox;

            if (testList.SelectedItem.ToString() != null)
            {
                setSpeech(testList.SelectedItem.ToString());
                string s = testList.SelectedItem.ToString();
                Clipboard.SetText(s, TextDataFormat.UnicodeText);
            }
        }
        












        public List<List<SimplyTest>> getFirstTest()
        {
            this.wrongAnswerImagePath = Path.GetFullPath(@"testsources\1\add_teaching_material.jpg");
            var test_case = new List<SimplyTest>()
            {

                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Отметь \"лишний\" предмет", // вот тут текст вопросa
                        ImageValue = null // картинка вопроса

                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "1", // вот тут текст который будет в варианте ответа
                            //ImageValue = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\testsources\1\1\1.png") // ккатринка ответа
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\1\1.png")) // ккатринка ответа
                        },
                        new RenderObject()
                        {
                            StringValue = "2",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\1\2.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue = "3",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\1\3.png"))
                        },
                        new RenderObject()
                        {
                            StringValue="4",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\1\4.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue="5",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\1\5.png"))
                        }
                    },
                    RightIdx=3 // индекс правильного ответа
                        
                },
                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Отметь \"лишний\" предмет",
                        ImageValue = null
                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "1",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\2\1.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue = "2",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\2\2.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue = "3",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\2\3.png"))
                        },
                        new RenderObject()
                        {
                            StringValue="4",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\2\4.png"))
                        },
                        new RenderObject()
                        {
                            StringValue="5",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\2\5.jpg"))
                        }
                    },
                    RightIdx=2

                },
                 new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Отметь \"лишний\" предмет",
                        ImageValue = null
                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "1",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\5\1.png"))

                        },
                        new RenderObject()
                        {
                            StringValue = "2",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\5\2.png"))
                        },
                        new RenderObject()
                        {
                            StringValue = "3",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\5\3.png"))
                        },
                        new RenderObject()
                        {
                            StringValue="4",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\5\4.png"))
                        }
                    },
                    RightIdx = 3

                },
                 new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Какого цвета эти предметы?",
                        ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\4\4.jpg"))
                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "оранжевого"
                        },
                        new RenderObject()
                        {
                            StringValue = "красного"
                        },
                        new RenderObject()
                        {
                            StringValue = "желтого"
                        },
                        new RenderObject()
                        {
                            StringValue="голубого"
                        }
                    },
                    RightIdx=2

                }

            };

            //Test.TestForm a = new Test.TestForm(test_case,this);
            //a.Show();

            var simplyQuestion = new List<SimplyTest>() {
                new SimplyTest() {
                    TestType = "Juxtaposition",
                Question = new RenderObject()
                {
                    StringValue = "Разложи фрукты и ягоды по баночкам"
                },
                Questions = new List<RenderObject>()
                {
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\2.jpg")
                    }
                },
                Variables = new List<RenderObject>()
                {
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\1-1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\1-2.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\1-3.png")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\1-4.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\2-1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\2-2.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\2-3.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\2-4.jpg")
                    }

                },
                RightIdx=30
            } };
            return new List<List<SimplyTest>>() { test_case, simplyQuestion };
        }


        public List<List<SimplyTest>> getSecondTest()
        {
            this.wrongAnswerImagePath = Path.GetFullPath(@"testsources\2\add_teaching_material.jpg");
            var test_case = new List<SimplyTest>()
            {

                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Отметь \"лишний\" предмет", // вот тут текст вопросa
                        ImageValue = null // картинка вопроса

                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "1", // вот тут текст который будет в варианте ответа
                            //ImageValue = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\testsources\1\1\1.png") // ккатринка ответа
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\1\1.jpg")) // ккатринка ответа
                        },
                        new RenderObject()
                        {
                            StringValue = "2",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\1\2.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue = "3",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\1\3.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue="4",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\1\4.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue="5",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\1\5.png"))
                        }
                    },
                    RightIdx=4 // индекс правильного ответа
                        
                },
                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Сколько на рисунке треугольников?", // вот тут текст вопросa
                        ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\2\2.jpg")) // картинка вопроса

                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "8", // вот тут текст который будет в варианте ответа
                            //ImageValue = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\testsources\1\1\1.png") // ккатринка ответа
                            ImageValue = null// Image.FromFile(Path.GetFullPath(@"testsources\2\1\1.png")) // ккатринка ответа
                        },
                        new RenderObject()
                        {
                            StringValue = "10",
                            ImageValue = null
                        },
                        new RenderObject()
                        {
                            StringValue = "11",
                            ImageValue = null
                        },
                        new RenderObject()
                        {
                            StringValue="12",
                            ImageValue = null
                        }
                    },
                    RightIdx=3 // индекс правильного ответа
                        
                },
                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Отметь \"лишний\" предмет", // вот тут текст вопросa
                        ImageValue = null // картинка вопроса

                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "1", // вот тут текст который будет в варианте ответа
                            //ImageValue = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\testsources\1\1\1.png") // ккатринка ответа
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\5\1.PNG"))
                        },
                        new RenderObject()
                        {
                            StringValue = "2",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\5\2.PNG"))
                        },
                        new RenderObject()
                        {
                            StringValue = "3",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\5\3.PNG"))
                        },
                        new RenderObject()
                        {
                            StringValue="4",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\5\4.PNG"))
                        },
                        new RenderObject()
                        {
                            StringValue="5",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\2\5\5.png"))
                        }
                    },
                    RightIdx=3 // индекс правильного ответа
                        
                },

            };
            var simplyQuestion = new List<SimplyTest>() {
                new SimplyTest() {
                    TestType = "Juxtaposition",
                Question = new RenderObject()
                {
                    StringValue = "Раздели предметы на квадратные и треугольные"
                },
                Questions = new List<RenderObject>()
                {
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\4\1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\4\2.jpg")
                    }
                },
                Variables = new List<RenderObject>()
                {
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\4\1-1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\4\1-2.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\4\1-3.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\4\1-4.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\4\2-1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\4\2-2.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\4\2-3.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\4\2-4.jpg")
                    }

                },
                RightIdx=30
            },

                new SimplyTest() {
                    TestType = "Juxtaposition",
                Question = new RenderObject()
                {
                    StringValue = "Раздели предметы на овальные и не овальные"
                },
                Questions = new List<RenderObject>()
                {
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\3\1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\3\2.jpg")
                    }
                },
                Variables = new List<RenderObject>()
                {
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\3\1-1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\3\1-2.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\3\1-3.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\3\1-4.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\3\2-1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\3\2-2.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\3\2-3.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\2\3\2-4.jpg")
                    }

                },
                RightIdx=30
            },

            };
            return new List<List<SimplyTest>>() { test_case, simplyQuestion };
        }



        public List<List<SimplyTest>> getLastTest()
        {
            this.wrongAnswerImagePath = Path.GetFullPath(@"testsources\18\add_teaching_material.PNG");
            var test_case = new List<SimplyTest>()
            {

                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Расшифруй слово, отметь соответсвующий рисунок", // вот тут текст вопросa
                        ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\1\0.jpg")) // ккатринка ответа

                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "1", // вот тут текст который будет в варианте ответа
                            //ImageValue = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\testsources\1\1\1.png") // ккатринка ответа
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\1\1.jpg")) // ккатринка ответа
                        },
                        new RenderObject()
                        {
                            StringValue = "2",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\1\2.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue = "3",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\1\3.jpg"))
                        }
                    },
                    RightIdx=2 // индекс правильного ответа
                        
                },
                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Расшифруй слово, отметь правильную запись", // вот тут текст вопросa
                        ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\2\1.jpg")) // ккатринка ответа

                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "лесовик", // вот тут текст который будет в варианте ответа
                            //ImageValue = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\testsources\1\1\1.png") // ккатринка ответа
                            ImageValue = null
                        },
                        new RenderObject()
                        {
                            StringValue = "картина",
                            ImageValue = null
                        },
                        new RenderObject()
                        {
                            StringValue = "камбала",
                            ImageValue = null
                        }
                    },
                    RightIdx=2 // индекс правильного ответа
                        
                },
                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Расшифруй слово, отметь соответсвующий рисунок", // вот тут текст вопросa
                        ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\3\0.jpg")) // ккатринка ответа

                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "1", // вот тут текст который будет в варианте ответа
                            //ImageValue = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\testsources\1\1\1.png") // ккатринка ответа
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\3\1.jpg")) // ккатринка ответа
                        },
                        new RenderObject()
                        {
                            StringValue = "2",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\3\2.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue = "3",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\3\3.jpg"))
                        }
                    },
                    RightIdx=2 // индекс правильного ответа
                        
                },
                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Расшифруй слово, отметь правильную запись", // вот тут текст вопросa
                        ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\4\1.jpg")) // ккатринка ответа

                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "козлята", // вот тут текст который будет в варианте ответа
                            //ImageValue = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\testsources\1\1\1.png") // ккатринка ответа
                            ImageValue = null
                        },
                        new RenderObject()
                        {
                            StringValue = "колбаса",
                            ImageValue = null
                        },
                        new RenderObject()
                        {
                            StringValue = "магазин",
                            ImageValue = null
                        }
                    },
                    RightIdx=1 // индекс правильного ответа
                        
                },
                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Расшифруй слово, отметь правильную запись", // вот тут текст вопросa
                        ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\18\5\1.jpg")) // ккатринка ответа

                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "клад", // вот тут текст который будет в варианте ответа
                            //ImageValue = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\testsources\1\1\1.png") // ккатринка ответа
                            ImageValue = null
                        },
                        new RenderObject()
                        {
                            StringValue = "соль",
                            ImageValue = null
                        },
                        new RenderObject()
                        {
                            StringValue = "стол",
                            ImageValue = null
                        }
                    },
                    RightIdx=2 // индекс правильного ответа
                        
                },
            };
            return new List<List<SimplyTest>>() { test_case};
        }
    }
}
