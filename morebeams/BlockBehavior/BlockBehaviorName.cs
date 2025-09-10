﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Datastructures;
using Vintagestory.API.MathTools;


namespace apebeams
{

    public class BlockBehaviorName(Block block) : BlockBehavior(block)
    {

        private List<string> parts;

        public override void Initialize(JsonObject properties)
        {
            base.Initialize(properties);

            parts = properties["parts"].AsObject<List<string>>();
            if (parts != null && parts.Any())
            {
                parts = parts.Select(x => Lang.GetMatching(x)).ToList();
            }
        }

        public override void GetPlacedBlockName(StringBuilder sb, IWorldAccessor world, BlockPos pos) => ConstructName(sb);

        public override void GetHeldItemName(StringBuilder sb, ItemStack itemStack) => ConstructName(sb);

        private void ConstructName(StringBuilder sb)
        {
            if (parts != null && parts.Any())
            {
                sb.Clear();
                sb.Append(string.Join("", parts));
            }
        }

    }
}
