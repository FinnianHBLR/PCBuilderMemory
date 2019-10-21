using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PCBuilderMemory2
{
    class PartCard
    {
        //Properties
        private string name;
        // private int id; //card value
        private bool type; //Alive or not
        private bool flipStatus;
        private string partType;
        private Bitmap cardImage;


        //Constructors

        public PartCard(string name, bool type, bool flipStatus, string partType, Bitmap cardImage)
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

        public bool getType()
        {
            return this.type;
        }

        public void setType(bool type)
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

        public Bitmap getImage()
        {
            return this.cardImage;
        }
    }
}

