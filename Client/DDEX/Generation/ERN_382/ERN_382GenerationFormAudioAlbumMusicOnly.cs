﻿using Framework.UI.Helpers;
using Business.DDEXSchemaERN_382.Schema;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using Business.DDEXSchemaERN_382.Entities;
using Business.DDEXSchemaERN_382;

namespace DDEX.Generation.ERN_382
{
    public partial class ERN_382GenerationFormAudioAlbumMusicOnly : GenerationForm
    {
        public ERN_382GenerationFormAudioAlbumMusicOnly()
        {
            InitializeComponent();
        }

        public AudioAlbumModel Model = new AudioAlbumModel() {  EAN = "Pero" };
        public Binder Binder = new Binder();

        #region Comments
        //private static NewReleaseMessage BindToObject()
        //{
        //    if (XmlObject == null)
        //    {
        //        XmlObject = new NewReleaseMessage()
        //        {
        //            ReleaseProfileVersionId = "CommonReleaseTypesTypes/13/AudioAlbumMusicOnly",
        //            LanguageAndScriptCode = "en",
        //            MessageSchemaVersionId = "ern/382",
        //            IsBackfill = false,
        //            IsBackfillSpecified = true
        //        };
        //    }
        //    XmlObject.UpdateIndicator = UpdateIndicator.OriginalMessage;
        //    if (XmlObject.MessageHeader == null)
        //    {
        //        XmlObject.MessageHeader = new MessageHeader();
        //    }

        //    XmlObject.MessageHeader.MessageId = messageID;
        //    XmlObject.MessageHeader.MessageThreadId = messageID;
        //    if (XmlObject.MessageHeader.MessageSender == null)
        //    {
        //        XmlObject.MessageHeader.MessageSender = new MessagingParty();
        //    }
        //    if (XmlObject.MessageHeader.MessageSender.PartyId == null)
        //    {
        //        PartyId[] senderIDs = { new PartyId() };
        //        XmlObject.MessageHeader.MessageSender.PartyId = senderIDs;
        //    }
        //    XmlObject.MessageHeader.MessageSender.PartyId[0].Value = senderPartyID;

        //    if (XmlObject.MessageHeader.MessageSender.PartyName == null)
        //    {
        //        XmlObject.MessageHeader.MessageSender.PartyName = new PartyName();
        //    }
        //    if (XmlObject.MessageHeader.MessageSender.PartyName.FullName == null)
        //    {
        //        XmlObject.MessageHeader.MessageSender.PartyName.FullName = new Name();
        //    }
        //    XmlObject.MessageHeader.MessageSender.PartyName.FullName.Value = senderPartyName;

        //    if (XmlObject.MessageHeader.MessageRecipient == null)
        //    {
        //        var o = new MessagingParty();
        //        MessagingParty[] messageRecipient = { o };
        //        XmlObject.MessageHeader.MessageRecipient = messageRecipient;
        //    }
        //    if (XmlObject.MessageHeader.MessageRecipient[0].PartyId == null)
        //    {
        //        PartyId[] recipientIDs = { new PartyId() };
        //        XmlObject.MessageHeader.MessageRecipient[0].PartyId = recipientIDs;
        //    }

        //    XmlObject.MessageHeader.MessageRecipient[0].PartyId[0].Value = recipientPartyID;

        //    if (XmlObject.MessageHeader.MessageRecipient[0].PartyName == null)
        //    {
        //        XmlObject.MessageHeader.MessageRecipient[0].PartyName = new PartyName();
        //    }
        //    if (XmlObject.MessageHeader.MessageRecipient[0].PartyName.FullName == null)
        //    {
        //        XmlObject.MessageHeader.MessageRecipient[0].PartyName.FullName = new Name();
        //    }

        //    XmlObject.MessageHeader.MessageRecipient[0].PartyName.FullName.Value = recipientPartyName;
        //    XmlObject.MessageHeader.MessageCreatedDateTime = new DateTime(messageCreatedDateTime.Value.Ticks, DateTimeKind.Local);

        //    XmlObject.UpdateIndicator = updateIndicator;
        //    XmlObject.UpdateIndicatorSpecified = true;

        //    if (XmlObject.ReleaseList == null)
        //    {
        //        XmlObject.ReleaseList = new ReleaseList();
        //    }
        //    if (XmlObject.ReleaseList.Release == null || XmlObject.ReleaseList.Release.Length == 0)
        //    {
        //        XmlObject.ReleaseList.Release = new Release[0];
        //    }
        //    if (XmlObject.ReleaseList.Release[0].ReleaseId == null || XmlObject.ReleaseList.Release[0].ReleaseId.Length == 0)
        //    {
        //        XmlObject.ReleaseList.Release[0].ReleaseId = new ReleaseId[0];
        //    }
        //    XmlObject.ReleaseList.Release[0].ReleaseId[0].ICPN.Value = EAN;


        //    return XmlObject;
        //}

        //private void BindToForm()
        //{
        //    if (XmlObject != null)
        //    {
        //        if (XmlObject.MessageHeader != null)
        //        {
        //            txtMessageID.Text = XmlObject.MessageHeader.MessageId;
        //            if (XmlObject.MessageHeader.MessageSender.PartyId.Length > 0)
        //            {
        //                txtMessageSender_PartyID.Text = XmlObject.MessageHeader.MessageSender.PartyId[0].Value;
        //            }
        //            if (XmlObject.MessageHeader.MessageSender.PartyName != null && XmlObject.MessageHeader.MessageSender.PartyName.FullName != null)
        //            {
        //                txtMessageSender_PartyName.Text = XmlObject.MessageHeader.MessageSender.PartyName.FullName.Value;
        //            }
        //            if (XmlObject.MessageHeader.MessageRecipient != null && XmlObject.MessageHeader.MessageRecipient.Length > 0 && XmlObject.MessageHeader.MessageRecipient[0].PartyId != null && XmlObject.MessageHeader.MessageRecipient[0].PartyId.Length > 0)
        //            {
        //                txtMessageRecipient_PartyID.Text = XmlObject.MessageHeader.MessageRecipient[0].PartyId[0].Value;
        //            }
        //            if (XmlObject.MessageHeader.MessageRecipient != null && XmlObject.MessageHeader.MessageRecipient.Length > 0 && XmlObject.MessageHeader.MessageRecipient[0].PartyName != null && XmlObject.MessageHeader.MessageRecipient[0].PartyName.FullName != null)
        //            {
        //                txtMessageRecipient_PartyName.Text = XmlObject.MessageHeader.MessageRecipient[0].PartyName.FullName.Value;
        //            }
        //            dpMessageCreatedDateTime.Value = XmlObject.MessageHeader.MessageCreatedDateTime;

        //            var val = ((List<ComboBoxItem>)cbUpdateIndicator.DataSource).Find(x => (UpdateIndicator)x.Value == XmlObject.UpdateIndicator);
        //            for (int i = 0; i < cbUpdateIndicator.Items.Count; i++)
        //            {
        //                if (cbUpdateIndicator.Items[i] == val)
        //                {
        //                    cbUpdateIndicator.SelectedIndex = i;
        //                }
        //            }

        //            txtEAN.Text = "";
        //            if (XmlObject.ReleaseList != null && XmlObject.ReleaseList.Release != null && XmlObject.ReleaseList.Release.Length > 0 && XmlObject.ReleaseList.Release[0].ReleaseId != null && XmlObject.ReleaseList.Release[0].ReleaseId.Length > 0)
        //            {
        //                txtEAN.Text = XmlObject.ReleaseList.Release[0].ReleaseId[0].ICPN.Value;
        //            }
        //        }
        //    }
        //}
        //public override IXmlObject GetXmlObject()
        //{
        //    var ret = new NewReleaseMessage()
        //    {
        //        ReleaseProfileVersionId = "CommonReleaseTypes/13/AudioSingle",
        //        LanguageAndScriptCode ="en",
        //        MessageSchemaVersionId = "ern/382"
        //    };

        //    PartyId[] senderIDs = { new PartyId() { Value = "DPID_OF_THE_SENDER" } };
        //    PartyId[] recipientIDs = { new PartyId() { Value = "DPID_OF_THE_RECIPIENT" } };
        //    var o = new MessagingParty() { PartyId = recipientIDs };
        //    MessagingParty[] messageRecipient = { o };

        //    ret.MessageHeader = new MessageHeader()
        //    {
        //        MessageThreadId = "", // unique za seriju poruka 
        //        MessageId = "", // svaka poruka ima ovo unique (new guid ili sl)
        //        MessageSender = new MessagingParty() { PartyId = senderIDs },
        //        MessageRecipient = messageRecipient,
        //        MessageCreatedDateTime = DateTime.Now
        //    };

        //    ret.UpdateIndicator = UpdateIndicator.OriginalMessage;
        //    ret.UpdateIndicatorSpecified = true;
        //    ret.IsBackfill = false;
        //    ret.IsBackfillSpecified = true;

        //    ret.ResourceList = new ResourceList();
        //    var lsSoundRecordings = new List<SoundRecording>();
        //    lsSoundRecordings.Add(
        //        new SoundRecording()
        //        {
        //            SoundRecordingCollectionReferenceList = new SoundRecordingCollectionReferenceList() {  SoundRecordingCollectionReference = new SoundRecordingCollectionReference[] { new SoundRecordingCollectionReference() {  SequenceNumber = "1" } } },
        //            SoundRecordingType = new SoundRecordingType1() {  Value =  SoundRecordingType.MusicalWorkSoundRecording },
        //            SoundRecordingId = new List<SoundRecordingId>() { new SoundRecordingId() {  ISRC = "CASE00000001" } }.ToArray(),
        //            IndirectSoundRecordingId = new List<MusicalWorkId>() { new MusicalWorkId() { ISWC = "T1234567890" } }.ToArray(), // ovo maknuti
        //            ResourceReference = "A1",
        //            ReferenceTitle = new ReferenceTitle() {  TitleText = new TitleText() { Value = "Prva pjesma" } },
        //            Duration = "PT3M33S",
        //            RightsAgreementId = new RightsAgreementId() { ProprietaryId = new ProprietaryId[] { new ProprietaryId() { Value = "DPID:xxx" } } }
        //        }
        //    );
        //    ret.ResourceList.SoundRecording = lsSoundRecordings.ToArray();
        //    var lsImages = new List<Image>();
        //    var lsImageId = new List<ResourceProprietaryId>();
        //    var lsProprietaryId = new List<ProprietaryId>();
        //    var lsImageDetailsByTerritory = new List<ImageDetailsByTerritory>();
        //    lsImageDetailsByTerritory.Add(
        //        new ImageDetailsByTerritory()
        //                {
        //                    ParentalWarningType = new ParentalWarningType1[] { new ParentalWarningType1() {  Value = ParentalWarningType.NotExplicit } },
        //                }
        //        );
        //    lsProprietaryId.Add(
        //        new ProprietaryId() {  Namespace = "DPID:xxx", Value = "PID0001" }
        //    );
        //    lsImageId.Add(
        //        new ResourceProprietaryId() {  ProprietaryId = lsProprietaryId.ToArray() }  
        //        );
        //    lsImages.Add(
        //        new Image()
        //        {
        //            ImageType = new ImageType1() { Value = ImageType.FrontCoverImage },
        //            ImageId = lsImageId.ToArray(),
        //            ResourceReference = "A2",
        //            ImageDetailsByTerritory = lsImageDetailsByTerritory.ToArray()

        //        }
        //    );
        //    ret.ResourceList.Image = lsImages.ToArray();

        //    ret.ReleaseList = new ReleaseList()
        //    {
        //         Release = new Release[] {
        //             new Release()
        //             {
        //                  IsMainRelease = true,
        //                  ReleaseId = new ReleaseId[] { new ReleaseId() {  GRid = "A1UCASE00000001X", ISRC = "CASE000001" } },
        //                  ReleaseReference = new string[] { "R0" },
        //                  ReferenceTitle = new ReferenceTitle() {  TitleText = new TitleText() { Value = "Moj prvi release" } },
        //                  //ReleaseCollectionReferenceList = new ReleaseCollectionReferenceList() {  }
        //                  //ReleaseType = new ReleaseType1[] { new ReleaseType1() {  Value = ReleaseType.Single } },
        //                  ReleaseDetailsByTerritory = new ReleaseDetailsByTerritory [] 
        //                  {
        //                      new ReleaseDetailsByTerritory()
        //                      {
        //                          DisplayArtistName = new Name[] { new Name() {  Value = "Lima"} },
        //                          LabelName = new  LabelName [] { new LabelName() {  Value = "Longplay records" } },
        //                          Title = new Title[] 
        //                          {
        //                              new Title() {  TitleText = new TitleText() {  Value = "Moj prvi release" } , TitleType = TitleType.FormalTitle },
        //                              new Title() {  TitleText = new TitleText() {  Value = "Moj prvi release display" } , TitleType = TitleType.DisplayTitle }
        //                          },
        //                          DisplayArtist = new Artist[]
        //                          {
        //                              new Artist()
        //                              {
        //                                  SequenceNumber = "1",
        //                                  Items = new object[] { new PartyName() { FullName = new Name() {  Value = "Lima" } } }
        //                              },
        //                              new Artist()
        //                              {
        //                                  SequenceNumber = "2",
        //                                  Items = new object[] { new PartyName() { FullName = new Name() {  Value = "Miro" } } }
        //                              }
        //                          },
        //                          ParentalWarningType = new ParentalWarningType1[]
        //                          {
        //                              new ParentalWarningType1() {  Value = ParentalWarningType.NotExplicit }
        //                          },
        //                          ResourceGroup = new ResourceGroup[]
        //                          {
        //                              new ResourceGroup()
        //                              {
        //                                  Title = new Title[]
        //                                  {
        //                                      new Title() {  TitleText = new TitleText() {  Value = "Moja prva pjesma" } }
        //                                  },
        //                                  SequenceNumber = "1"
        //                              }
        //                          },
        //                          PLine = new PLine[]
        //                          {
        //                              new PLine() {  Year = "2016", PLineText = "(P) 2010 Longplay music" }
        //                          },
        //                          CLine = new CLine[]
        //                          {
        //                              new CLine() {  Year = "2016", CLineText = "(P) 2010 Longplay music"}
        //                          },
        //                          OriginalReleaseDate = new EventDate() {  Value = "2016-12-01" }

        //                      }
        //                  }

        //             }
        //         }
        //    };

        //    return ret;
        //}
        //private NewReleaseMessage XmlObject { get; set; }
        #endregion

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lblPath.Text = dlg.FileName;

                    var xmlObject = Binder.GetXmlObjectFromFile(lblPath.Text);
                    Model = (AudioAlbumModel) Binder.GetModelFromXmlObject(xmlObject);
                }
            }
        }
                
        
        protected override void OnGenerateClicked(object sender, EventArgs e)
        {
            base.OnGenerateClicked(sender, e);
            rtbOutput.Text = "";
            string msg = "";
            bool isValid = Binder.IsModelValid(Model, out msg);
            if (isValid)
            {
                Binder.WriteXmlObjectToFile(Binder.GetXmlObjectFromModel(Model), lblPath.Text);
            }
            else
            {
                rtbOutput.Text =  msg + "---\n" + rtbOutput.Text.ToString() + "\n";
            }

            var srd = new SoundRecordingDetailsByTerritory();
            
        }
        
        private void ERN_382GenerationFormAudioAlbumMusicOnly_Load(object sender, EventArgs e)
        {
            lblPath.Text = "C:\\temp\\file.xml";
            Model = (AudioAlbumModel) Binder.GetModelFromXmlObject(Binder.GetXmlObjectFromFile(lblPath.Text));
            InitBindings();
        }
        private void bbTracks_Changed(object sender, Framework.UI.Controls.MRButtonBar.ButtonBarChangedEventArgs e)
        {
            if (e.ButtonType == Framework.UI.Controls.MRButtonBar.eButtonType.Add)
            {
                Tracks.Add(new TrackModel() { Ordinal = Tracks.Count + 1 });
            }
            else if (e.ButtonType == Framework.UI.Controls.MRButtonBar.eButtonType.Delete)
            {
                if (dgvSoundRecordingsAndReleases.SelectedRows != null && dgvSoundRecordingsAndReleases.SelectedRows.Count > 0)
                {
                    dgvSoundRecordingsAndReleases.Rows.Remove(dgvSoundRecordingsAndReleases.SelectedRows[0]);
                }
            }
        }

        private void InitBindings()
        {
            cbUpdateIndicator.DataSource = new List<ComboBoxItem>() { new ComboBoxItem() { Text = "OriginalMessage", Value = UpdateIndicator.OriginalMessage }, new ComboBoxItem() { Text = "UpdateMessage", Value = UpdateIndicator.UpdateMessage } };
            tbMainRelease.BindedControls.Add(pnlMainRelease);
            tbMessageHeader.BindedControls.Add(pnlMessageHeader);
            tbTrackReleases.BindedControls.Add(pnlTrackReleases);

            dgvSoundRecordingsAndReleases.DataSource = Tracks;

            txtEAN.DataBindings.Add("Text", Model, "EAN");
            txtMessageID.DataBindings.Add("Text", Model, "MessageID");
            txtMessageSender_PartyID.DataBindings.Add("Text", Model, "SenderPartyID");
            txtMessageSender_PartyName.DataBindings.Add("Text", Model, "SenderPartyName");
            txtMessageRecipient_PartyID.DataBindings.Add("Text", Model, "RecipientPartyID");
            txtMessageRecipient_PartyName.DataBindings.Add("Text", Model, "RecipientPartyName");

            dpMessageCreatedDateTime.DataBindings.Add("Value", Model, "MessageCreatedDateTime");

            cbUpdateIndicator.DataBindings.Add("SelectedItem", Model, "UpdateIndicator");
            txtMainReleaseReferenceTitle.DataBindings.Add("Text", Model, "MainReleaseReferenceTitle");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

            }

        }
        public BindingList<TrackModel> Tracks { get; set; } = new BindingList<TrackModel>();

    }

    
}
