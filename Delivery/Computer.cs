using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{

    class Computer : Product
    {
        private ushort hardDriveSize;
        private byte ram;
        private bool hasGPU;
        private string cpuType;
        private string companyProduced;
        private ushort yearCreated;
        public Computer(string name, float price,
            ushort hardDriveSize, byte ram,
            bool hasGPU, string cpuType,
            string companyProduced, ushort yearCreated) : base(name, price) 
        {
            this.hardDriveSize = hardDriveSize;
            this.ram = ram;
            this.hasGPU = hasGPU;
            this.cpuType = cpuType;
            this.companyProduced = companyProduced;
            this.yearCreated = yearCreated;
        }
        public ushort HardDriveSize
        {
            get { return this.hardDriveSize; }
            set { this.hardDriveSize = value; }
        }
        public byte RAM
        {
            get { return this.ram; }
            set { this.ram = value; }
        }
        public bool HasGPU
        {
            get { return this.hasGPU; }
            set { this.hasGPU = value; }
        }
        public string CPUType
        {
            get { return this.cpuType; }
            set { this.cpuType = value; }
        }
        public string CompanyProduced
        {
            get { return this.companyProduced; }
            set { this.companyProduced = value; }
        }
        public ushort YearCreated
        {
            get { return this.yearCreated; }
            set { this.yearCreated = value; }
        }

    }

}
