using System;
using System.Collections;
using System.Collections.Generic;

namespace SiLi.Max
{
    public class LocationBasket
    {
        public ICollection<LocationRecord> LocationRecords { get; set; }
    }

    public class LocationRecord
    {
        public Guid Id { get; set; }
        public long Timestamp { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }

        public ILocationRecordMetaData MetaData { get; set; }

        public ILocationHash GetHash()
        {
            return null;
        }
    }

    public interface ILocationHash
    {

    }

    public class LocationBlockRefs
    {
        public ILocationHash LocationHash { get; set; }
        public Guid[] BlockReferences { get; set; }
    }

    public class BlocksGraphDb
    {
        public IGraph<IBlock> Blocks { get; set; }
    }

    public interface IGraph<T>
    {

    }


    public interface IBlock
    {
        Guid Ref { get; }
    }

    public interface IConvolutionBlock : IBlock
    {

    }

    public interface IKnowledgeGraphBlock : IBlock
    {

    }


    public interface IAudioProcessingBlock : IBlock
    {

    }


    public interface IBasicNeuralNetworkBlock : IBlock
    {

    }


    public interface IAutoEncoderBlock : IBlock
    {

    }


    public interface IConceptBlock : IBlock
    {

    }
}
