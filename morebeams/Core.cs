using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

[assembly: ModInfo("apebeams",
                    Authors = new string[] { "xXx_Ape_xXx" },
                    Description = "Create beams of various sizes and decorations",
                    Version = "1.1.1")]

namespace arrowbarrels
{
    public sealed class Core : ModSystem
    {
        private ICoreAPI api;

        public override void Start(ICoreAPI api)
        {
            this.api = api;

            this.RegisterBlocks(api);
            this.RegisterEntityclasses(api);
            this.RegisterColBehaviours(api);

            base.Start(api);
            api.World.Logger.Event("started 'More Beams' mod");
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            this.api = api;
            base.StartServerSide(api);
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            this.api = api;
            base.StartClientSide(api);
        }

        private void RegisterBlocks(ICoreAPI api)
        {
        }

        private void RegisterEntityclasses(ICoreAPI api)
        {
        }
        private void RegisterColBehaviours(ICoreAPI api)
        {
        }


        public override void Dispose()
        {
            base.Dispose();
        }

    }
}
