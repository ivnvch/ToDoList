using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class SaveData
    {
        /// <summary>
        /// Этот класс я сделал не сам. В целом, я понимаю, что здесь и зачем. Но задумка была сделать сохранение данных в базу, но
        /// я не смог.
        /// </summary>


        private readonly string PATH;
        public SaveData(string path)
        {
            PATH = path;
        }
        public BindingList<List> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<List>();
            }
            using(var reader = File.OpenText(PATH))
            {
                var filetext = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<List>>(filetext);
            }
        }

        public void Save(object lists)
        {
            using(StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(lists);
                writer.Write(output);
            }
        }
    }
}
