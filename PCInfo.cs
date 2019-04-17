using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCInfo
{
    public class PCInfo
    {
            public CPU[] CPU { get; set; }
            public 主板[] 主板 { get; set; }
            public 内存[] 内存 { get; set; }
            public 网卡[] 网卡 { get; set; }
            public 系统[] 系统 { get; set; }
            public 磁盘[] 磁盘 { get; set; }
            public 打印机[] 打印机 { get; set; }
            public 显卡[] 显卡 { get; set; }  
    }
    
    public class CPU
    {
        public string CPU序列号 { get; set; }
        public string CPU名称 { get; set; }
        public string 设备ID { get; set; }
        public string 名称 { get; set; }
        public string 状态 { get; set; }
        public string CPU级别 { get; set; }
        public string 主机名 { get; set; }
        public string 处理器类型 { get; set; }
    }

    public class 主板
    {
        public string 主板ID { get; set; }
        public string 制造商 { get; set; }
        public string 型号 { get; set; }
        public string 版本 { get; set; }
    }

    public class 内存
    {
        public string 内存类型 { get; set; }
        public string 速度 { get; set; }
        public string 容量 { get; set; }
        public string 插槽 { get; set; }
        public string 位置 { get; set; }
        public string 型号 { get; set; }
        public string 序列号 { get; set; }
    }

    public class 网卡
    {
        public string 名称 { get; set; }
        public string MAC地址 { get; set; }
        public string IP地址 { get; set; }
    }

    public class 系统
    {
        public string 启动设备 { get; set; }
        public string 系统名称 { get; set; }
        public string 计算机名 { get; set; }
        public string 系统位数 { get; set; }
        public string 序列号 { get; set; }
        public string 系统硬件位置 { get; set; }
        public string 系统目录 { get; set; }
        public string 系统盘符 { get; set; }
        public string 系统版本 { get; set; }
        public string 安装时间 { get; set; }
    }

    public class 磁盘
    {
        public string 设备ID { get; set; }
        public string 设备名称 { get; set; }
        public string 序列号 { get; set; }
        public string 接口类型 { get; set; }
        public string 型号 { get; set; }
        public string 容量 { get; set; }
    }

    public class 打印机
    {
        public string 设备名称 { get; set; }
        public string 设备ID { get; set; }
        public string 驱动名称 { get; set; }
        public string 使用接口 { get; set; }
    }

    public class 显卡
    {
        public string 设备名称 { get; set; }
        public string 显存 { get; set; }
        public string 设备ID { get; set; }
        public string 分辨率 { get; set; }
    }
}
