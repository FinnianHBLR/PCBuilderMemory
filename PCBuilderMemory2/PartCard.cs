using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PCBuilderMemory
{
    class PartCard
    {
        //Properties
        private string name;
        // private int id; //card value
        private string type; //Alive or not
        private bool flipStatus;
        private string partType;
        private Image cardImage;


        //Constructors

        public PartCard(string name, string type, bool flipStatus, string partType, Image cardImage)
        {
            this.name = name;
            this.type = type;
            this.flipStatus = flipStatus;
            this.partType = partType;
            this.cardImage = cardImage;
        }

        //Methods

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public string getType()
        {
            return this.type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setPartType(string part)
        {
            this.partType = part;
        }

        public string getPartType()
        {
            return this.partType;
        }

        public void setFlipStatus(bool status)
        {
            this.flipStatus = status;
        }

        public bool getFlipStatus()
        {
            return this.flipStatus;
        }

        public Image getImage()
        {
            return this.cardImage;
        }
    }
}

