﻿using MediaBrowser.Model.Dto;
using MediaBrowser.Model.LiveTv;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediaBrowser.Controller.LiveTv
{
    public interface ITunerHost
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        string Type { get; }
        /// <summary>
        /// Gets the tuner hosts.
        /// </summary>
        /// <returns>List&lt;TunerHostInfo&gt;.</returns>
        List<TunerHostInfo> GetTunerHosts();
        /// <summary>
        /// Gets the channels.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;IEnumerable&lt;ChannelInfo&gt;&gt;.</returns>
        Task<IEnumerable<ChannelInfo>> GetChannels(TunerHostInfo info, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the tuner infos.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;List&lt;LiveTvTunerInfo&gt;&gt;.</returns>
        Task<List<LiveTvTunerInfo>> GetTunerInfos(TunerHostInfo info, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the channel stream.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="channelId">The channel identifier.</param>
        /// <param name="streamId">The stream identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;MediaSourceInfo&gt;.</returns>
        Task<MediaSourceInfo> GetChannelStream(TunerHostInfo info, string channelId, string streamId, CancellationToken cancellationToken);
    }
}