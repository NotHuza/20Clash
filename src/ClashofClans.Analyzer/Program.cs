using System;
using ClashofClans.Utilities.Netty;
using DotNetty.Buffers;

namespace ClashofClans.Analyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hex = "00000000D10E818200000000D10E8182010000000000000001000000035543530000000000000001000000010000000000000000000000000000000000000003E8000000000000000000000000000000000000000000000000000000000000000000000000000003E80000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A00000000000000000000000000000000000000000000000000000000000000000000000000000003496E63FFFFFFFF000000010000001C000F4238000001BC0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002FFFFFFFF00000000000000000000000000000000000000000000000006002DC6C0000F4238002DC6C17735693A002DC6C2773590F9002DC6C377359400002DC6C777359400002DC6C87735940000000006002DC6C0000F4238002DC6C17735693A002DC6C2773590F9002DC6C377359400002DC6C777359400002DC6C87735940000000001003D09000000000B000000000000000000000000000000000000000000000000000000000000000101AB3F0300000003000000000000002301406F4001406F4101406F4201406F4301406F4401406F4501406F4601406F4701406F4801406F4901406F4B01406F4C01406F4D01406F4E01406F4F01406F5001406F5101406F5201406F5301406F5401406F5501406F5601406F5701406F5801406F5901406F5A01406F5B01406F5C01406F5D01406F5E01406F5F01406F6001406F6101406F6201406F4A00000001015EF3C3000000000000005E01036640000000030103664100000003010366420000000301036643000000030103664400000003010366450000000301036646000000030103664700000003010366480000000301036649000000030103664A000000030103664B000000030103664C000000030103664D000000030103664E000000030103664F0000000301036650000000030103665100000003010366520000000301036653000000030103665400000003010366550000000301036656000000030103665700000003010366580000000301036659000000030103665A000000030103665B000000030103665C000000030103665D000000030103665E000000030103665F0000000301036660000000030103666100000003010366620000000301036663000000030103666400000003010366650000000301036666000000030103666700000003010366680000000301036669000000030103666A000000030103666B000000030103666C000000030103666D000000030103666E000000030103666F0000000301036670000000030103667100000003010366720000000301036673000000030103667400000003010366750000000301036676000000030103667700000003010366780000000301036679000000030103667A000000030103667B000000030103667C000000030103667D000000030103667E000000030103667F0000000301036680000000030103668100000003010366820000000301036683000000030103668400000003010366850000000301036686000000030103668700000003010366880000000301036689000000030103668A000000030103668B000000030103668C000000030103668D000000030103668E000000030103668F0000000301036690000000030103669100000003010366920000000301036693000000030103669400000003010366950000000301036696000000030103669700000003010366980000000301036699000000030103669A000000030103669B000000030103669C000000030103669D000000030000000000000000000000000000000000000000000000000000000000000000000000610000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000FF000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000140000000000000000000000000000000000000000000000000000000001000000000000052EDF1A0000789C9D58D1721B370CFC977BD6C39100793AFF4AC7A391ED6BAA46913D96E224E3F1BF5716B12E481072DABCE49225162001024BBD0ECBCFA7CDCBF23CDC84D570F77DB77FD81DBE1C879B3F5E8787ED697BFEEFF1FDCF19FC39DC445E0DBFCE7FD16AD8BFEC879BF16D552FE3B28C2ECBC2EC2D1BCBB2B9B0C5D5F0FDB03BBD3BBD5D0DC7D3E3F3F6CBB239FD7A5ACEA60E454885225C0F284840EBCB324AFFC3D3980B452A9EA642B1797A7E7C186E5ECB3F84E1CDA3883A8A98BD65F59E92B76C5D96E5B2EC1CF7F674DADE7FDD7C7B7C3847F1E7767F5C3C532AA6B198AE3FF120F1CE573D9C0FF2F1EE7886F78B2E9BF58568BA10954843FED78D468324C7C0258AE982CE2D58CE8A4A56528B66CDCCDCC2A32E5383AEB57134DCC53317E318FA9B9AFAD4E5FCA95CA3105B98F52DB370098C0A7734E4A9DA95B116DF25F734F5ADCB7992312E6828A519C83913A9C8168D9ADA382EE8DAD95441C378B5460A359BB0828EDA2452D0529DB476E0E2999D3C5FCF64908B66C266BD6753DB25533C5E2D4029031BB7E4A2B80EE640655BC53A38BB16EBD675904626AEDBF31698CB79B7D4A1EAFAE640050EFD9B1348C765322DB0E4D2A443C640A07E81624A94C882A9DFAC6F3C19EBA0FBB1A96FC0B22F435EB64DA393CDB11A601E3CF71322458AD09C1B40255F64CE9C2BD8E90992124B9EAAEB751914A7E7ED930CDF87E5FE513E5F1EEFFED6A38366BD35E9F06C6795AC8BBAA7AA75B71FC3FEB51AD96FE7317D7C5AF6FB3EB25BCE92E0DBF6FEAFDD61E9AEF81049B15549C4955488CE7825D2E7EA4E61590695F4C932A2DF5B36FEDEB24F140255832C7692D35BF6D981F0757DD42CF3345FB3CC935194AA64794E79D492E95D14FC67F9C75C1DBD7B58B36E52E489E744BA1B058F8D45B68E9F6C2FEA0EF1DE7CFBB14D558774635B6BBDC75D8D185B91282190D35EB91C0BC9B06CDB6B1AAB69E8C1A518DA399CAAEE6AC6348CFB038B83DAAC51265CCD59D3B8B97E50B5124060763A3360EA6A63AEDA7A7B2208ACAF9C059DAE9A8E7D3D0FBF52BF8E71EE8FAA66C7CE79491ECDB0E1A9BA14EDA81258F26CA4B1C0A2134D0D093CF7152A6B2168C29EB5F4351534EB978629DDAC13652BBBC034F7B70CEBD0973C29E9F660AD271D77BB2B4165E238B681BBC509DBBECC139445569B3D576936D7029E1DA925305A621B770E95D46A7DE75849ADB60205163564AA04D6DCBD7579AC92655C57B011BF02CBA119CFA3AA5EA36DD3ACEEBB6DAEB3BED10E2A893661C1D8699F02236A93CBB97A669B329AF51BC9712D43DB946F75EDBCB09D7B33EB3C729B485C4A99800E2C71D9FAAD7E6AB2F59B75AE9C0B1FBD7EB0AE4488038B6BF36A1438CCFD57234E343B6554CD42733744D1483E4C8972FDAB88A9A3A0AD4DC2B2A8E8D0CF08E0781DA6FEB164AEACDBD0000707AEC98DEF9ABC9DB6020727DF0D6C7A461D9A19E5522D10C70EEC5CCEC6DA0CEB1A364AA0AA5437B4D01F1180631F46AF74C845F141E198DE10D4ACB7C6A4EEA7F5ACE5A2A750F0ABCDFCF15A8EEAB91CD57B39DA0773D0ED38759E47B28ED44048598BF4FDF678DA1C961FC7CD71590E97DFC48F5F7787F7C7798AE2433E181F091F191F133ED6F898E5E37CAEF2019E10F141F8007300730073007300730073047304730473047304730473047304730421819040482024101208098404420221215402338399C1CC606630339819CC0C6606338399C19CC09CC09CC09CC09CC09CC09CC09CC09CC09CC09CC19CC19CC19CC19CC19CC19CC19CC19CC19CC13C817902F304E609CC139827304F609EC03C817902F37ABC7DFB07CC70B276000000000000000000000000000000000000000000";
            hex = hex.Replace(" ", string.Empty);

            var buffer = Unpooled.Buffer();
            buffer.WriteHex(hex);

            buffer.SetReaderIndex(0);

            //DecodeHeader(buffer);

            /*for(var i = 0; i < 97; i++)
                Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");*/

            //DecodeLogicClientHome(buffer);
            DecodeLogicClientAvatar(buffer);
            Console.WriteLine(buffer.ReadCompressedString(false));

            buffer.DiscardReadBytes();
            Console.WriteLine(BitConverter.ToString(buffer.ReadBytes(buffer.ReadableBytes).Array).Replace("-", string.Empty));

            Console.Read();
        }

        public static void DecodeHeader(IByteBuffer buffer)
        {
            Console.WriteLine("--HEADER--");
            Console.WriteLine($"ID:      {buffer.ReadShort()}");
            Console.WriteLine($"Length:  {buffer.ReadMedium()}");
            Console.WriteLine($"Version: {buffer.ReadShort()}");
            Console.WriteLine("--HEADER END--");
        }

        public static void DecodeLogicClientAvatar(IByteBuffer buffer)
        {
            Console.WriteLine(buffer.ReadLong());
            Console.WriteLine(buffer.ReadLong());

            Console.WriteLine(buffer.ReadByte()); // HasAlliance

            Console.WriteLine("--ALLIANCE--");
            Console.WriteLine(buffer.ReadLong());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt()); // Badge
            Console.WriteLine(buffer.ReadInt()); // Members
            Console.WriteLine(buffer.ReadInt()); // Members

            Console.WriteLine(buffer.ReadByte());
            Console.WriteLine(buffer.ReadLong());
            Console.WriteLine("--ALLIANCE END--");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt()); // Exp Level
            Console.WriteLine(buffer.ReadInt()); // Exp Points

            Console.WriteLine(buffer.ReadInt()); // Diamonds
            Console.WriteLine(buffer.ReadInt()); // Diamonds

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt()); // Trophies
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt()); // Clan Castle Gold
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadByte());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadByte());

            var recourceCapCount = buffer.ReadInt();
            for (var i = 0; i < recourceCapCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            var resourceCount = buffer.ReadInt();
            for (var i = 0; i < resourceCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            var troopCount = buffer.ReadInt();
            for (var i = 0; i < troopCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            var spellCount = buffer.ReadInt();
            for (var i = 0; i < spellCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            var troopLevelCount = buffer.ReadInt();
            for (var i = 0; i < troopLevelCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            var spellLevelCount = buffer.ReadInt();
            for (var i = 0; i < spellLevelCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            var heroLevelCount = buffer.ReadInt();
            for (var i = 0; i < heroLevelCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            var heroHealthCount = buffer.ReadInt();
            for (var i = 0; i < heroHealthCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            var heroStateCount = buffer.ReadInt();
            for (var i = 0; i < heroStateCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            Console.WriteLine($"ClanUnits: {buffer.ReadInt()}");

            var unknownCount = buffer.ReadInt();
            for (var i = 0; i < unknownCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            Console.WriteLine(buffer.ReadInt());

            var missionCount = buffer.ReadInt();
            for (var i = 0; i < missionCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
            }

            var achivementCount = buffer.ReadInt();
            for (var i = 0; i < achivementCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            var completedAchivementCount = buffer.ReadInt();
            for (var i = 0; i < completedAchivementCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            Console.WriteLine(buffer.ReadInt());

            var npcCount = buffer.ReadInt();
            for (var i = 0; i < npcCount; i++)
            {
                Console.WriteLine(buffer.ReadInt());
                Console.WriteLine(buffer.ReadInt());
            }

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");

            for (var i = 0; i < 97; i++)
            {
                Console.WriteLine($"packet.WriteInt({buffer.ReadInt()});");
            }

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadByte());
        }

        public static void DecodeLogicClientHome(IByteBuffer buffer)
        {
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadLong());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt()); // 14400

            Console.WriteLine(buffer.ReadCompressedString());
            Console.WriteLine(buffer.ReadCompressedString());
            Console.WriteLine(buffer.ReadCompressedString());
        }

        public static void DecodeLoginOk(IByteBuffer buffer)
        {
            Console.WriteLine(buffer.ReadLong());
            Console.WriteLine(buffer.ReadLong());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());

            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());
            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadByte());
            Console.WriteLine(buffer.ReadByte());

            Console.WriteLine(buffer.ReadScString());

            Console.WriteLine(buffer.ReadInt());
        }
    }
}
