﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entitas;
using PokemonBattele;

class InitUseSkillSpecialEffectSystem : IInitializeSystem
{
    public void Initialize()
    {
        //雷电拳
        UseSkillEffectManager.UseSkillDic[9] =new List<IUseSkillSpecialEffect>()
        { new ParalysisEffect(10) };

        //火花
        UseSkillEffectManager.UseSkillDic[52] = new List<IUseSkillSpecialEffect>()
        { new BurnsEffect(10) };

        //暴风雪
        UseSkillEffectManager.UseSkillDic[59] = new List<IUseSkillSpecialEffect>()
        { new FrostbiteEffect(10) };

        //泡沫光线
        UseSkillEffectManager.UseSkillDic[61] = new List<IUseSkillSpecialEffect>()
        { new ChangeSpeedStatModifiersEffect(10,1,false) };

        //极光束
        UseSkillEffectManager.UseSkillDic[61] = new List<IUseSkillSpecialEffect>()
        { new ChangePhysicPowerStatModifiersEffect(10,1,false) };

        //花瓣舞80 //连续多回合攻击

        //电击
        UseSkillEffectManager.UseSkillDic[84] = new List<IUseSkillSpecialEffect>()
        { new ParalysisEffect(10) };

        //十万伏特
        UseSkillEffectManager.UseSkillDic[85] = new List<IUseSkillSpecialEffect>()
        { new ParalysisEffect(10) };

        //电磁波
        UseSkillEffectManager.UseSkillDic[86] = new List<IUseSkillSpecialEffect>()
        { new ParalysisEffect(100) };

        //打雷
        UseSkillEffectManager.UseSkillDic[87] = new List<IUseSkillSpecialEffect>()
        { new ParalysisEffect(30) };

        //神鸟猛击143 //准备一回合

        //泡沫
        UseSkillEffectManager.UseSkillDic[145] = new List<IUseSkillSpecialEffect>()
        { new ChangeSpeedStatModifiersEffect(10,1,false) };

        //岩崩157 畏惧

        //火焰轮
        UseSkillEffectManager.UseSkillDic[172] = new List<IUseSkillSpecialEffect>()
        { new BurnsEffect(10) };

        //气旋攻击 177 击中要害

        //污泥炸弹
        UseSkillEffectManager.UseSkillDic[188] = new List<IUseSkillSpecialEffect>()
        { new PoisonEffect(30) };

        //电磁炮
        UseSkillEffectManager.UseSkillDic[192] = new List<IUseSkillSpecialEffect>()
        { new ParalysisEffect(100) };

        //电光
        UseSkillEffectManager.UseSkillDic[209] = new List<IUseSkillSpecialEffect>()
        { new ParalysisEffect(30) };

        //光合作用 235 恢复生命

        //暗影球
        UseSkillEffectManager.UseSkillDic[247] = new List<IUseSkillSpecialEffect>()
        { new ChangeEnergyDefenceStatModifiersEffect(20,1,false) };

        //洁净光芒
        UseSkillEffectManager.UseSkillDic[295] = new List<IUseSkillSpecialEffect>()
        { new ChangeEnergyDefenceStatModifiersEffect(50,1,false) };


        //火焰踢 击中要害率
        UseSkillEffectManager.UseSkillDic[299] = new List<IUseSkillSpecialEffect>()
        {new BurnsEffect(10) };

        //加农水炮 308
        //玩家在接下来的一回合内无法作出包括使出招式、使用道具、逃走、替换宝可梦的任何指令。

        //银色旋风
        UseSkillEffectManager.UseSkillDic[318] = new List<IUseSkillSpecialEffect>()
        {new ChangeAllStatModifiersEffect(10,1,true) };


        //信号光束 324 混乱

        //恶之波动  399 畏缩

        //暗袭要害 400 要害

        //雪崩 419 如果本回合内被目标使用了攻击招式攻击并被造成了伤害，威力翻倍。

        //火焰牙 424
        //火焰牙有10 % 的几率使目标陷入畏缩状态。
        UseSkillEffectManager.UseSkillDic[424] = new List<IUseSkillSpecialEffect>()
        {new BurnsEffect(10) };

        //泥巴炸弹 426
        //30 % 几率令目标的命中率降低1级。

        //流星群
        UseSkillEffectManager.UseSkillDic[434] = new List<IUseSkillSpecialEffect>()
        {new ChangeEnergyPowerStatModifiersEffect(100,2,false)};

        //放电
        UseSkillEffectManager.UseSkillDic[435] = new List<IUseSkillSpecialEffect>()
        {new ParalysisEffect(30) };

        //岩石炮439
        //玩家在接下来的一回合内无法作出包括使出招式、使用道具、逃走、替换宝可梦的任何指令。

        //充电光束
        UseSkillEffectManager.UseSkillDic[451] = new List<IUseSkillSpecialEffect>()
        {new ChangeEnergyPowerStatModifiersEffect(70,1,true)};

        //种子闪光
        UseSkillEffectManager.UseSkillDic[465] = new List<IUseSkillSpecialEffect>()
        {new ChangeEnergyDefenceStatModifiersEffect(40,2,false)};

        //蓄能焰袭
        UseSkillEffectManager.UseSkillDic[488] = new List<IUseSkillSpecialEffect>()
        {new ChangePhysicPowerStatModifiersEffect(100,1,true)};

        //酸液炸弹
        UseSkillEffectManager.UseSkillDic[491] = new List<IUseSkillSpecialEffect>()
        {new ChangeEnergyDefenceStatModifiersEffect(100,2,false)};

        //棉花防守
        UseSkillEffectManager.UseSkillDic[538] = new List<IUseSkillSpecialEffect>()
        {new ChangePhysicDefenceStatModifiersEffect(100,3,true)};

        //暗黑爆破539
        //40%几率令目标的命中率降低1级。

        //暴风542
        //暴风有30 % 的几率使目标陷入混乱状态。
    }
}
