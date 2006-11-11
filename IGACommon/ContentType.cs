using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace au.id.micolous.libs.igacommon
{
    /// <summary>
    /// Represents a contentType value.
    /// </summary>
    public class ContentType
    {
        private uint _contentType;

        /// <summary>
        /// The numeric representation of the contentType stored.
        /// </summary>
        public uint contentType { get { return this._contentType; } }

        /// <summary>
        /// No-args constructor that defines a DDS image, 128x256.
        /// </summary>
        public ContentType()
        {
            this._contentType = 2021100;
        }

        /// <summary>
        /// Create a new contentType, based on it's integral representation.
        /// </summary>
        /// <param name="ContentType">The contentType of the image.</param>
        public ContentType(uint ContentType)
        {
            this._contentType = ContentType;
        }

        /// <summary>
        /// Create a new ContentType, based on size parameters.
        /// </summary>
        /// <param name="dimensions">The dimensions of the image.</param>
        /// <param name="type">The type of image/video.</param>
        public ContentType(Size dimensions, ItemType type)
        {
            switch (dimensions.Width)
            {
                case 128:
                    switch (dimensions.Height)
                    {
                        case 128:
                            this._contentType = 2041000;
                            break;
                        case 256:
                            this._contentType = 2021000;
                            break;
                        default:
                            throw new UnsupportedImageSizeException();
                    }
                    break;
                case 256:
                    switch (dimensions.Height)
                    {
                        case 256:
                            this._contentType = 3041000;
                            break;
                        case 512:
                            this._contentType = 3021000;
                            break;
                        default:
                            throw new UnsupportedImageSizeException();
                    }
                    break;
                case 512:
                    switch (dimensions.Height)
                    {
                        case 128:
                            this._contentType = 2101000;
                            break;
                        case 256:
                            this._contentType = 2081000;
                            break;
                        default:
                            throw new UnsupportedImageSizeException();
                    }
                    break;
                default:
                    throw new UnsupportedImageSizeException();
            }

            if (type == ItemType.BinkVideo)
            {
                // do nothing.
            }
            else if (type == ItemType.DDSImage)
            {
                this._contentType += 100;
            }
            else
            {
                throw new UnsupportedImageTypeException();
            }
            
        }

        /// <summary>
        /// Get the size of the image.
        /// </summary>
        /// <returns>A Size, describing the size of the image.</returns>
        public Size GetSize()
        {
            return Common.ContentTypeToSize(this._contentType);
        }

        /// <summary>
        /// Gets the type of data that this contentType describes.
        /// </summary>
        /// <returns>An ItemType showing what type of data is stored.</returns>
        public ItemType GetItemType()
        {
            switch (this._contentType % 1000)
            {
                case 0:
                    return ItemType.BinkVideo;
                case 100:
                    return ItemType.DDSImage;
                default:
                    throw new UnsupportedImageTypeException();
            }
        }

        /// <summary>
        /// Changes the item type set.
        /// </summary>
        /// <param name="type">The item's new type.</param>
        public void SetItemType(ItemType type)
        {
            uint ct = _contentType / 10000;
            ct = ct * 10000;

            switch (type)
            {
                case ItemType.BinkVideo:
                    ct += 1000;
                    break;
                case ItemType.DDSImage:
                    ct += 1100;
                    break;
                default:
                    throw new UnsupportedImageTypeException();
            }
            _contentType = ct;
        }

        /// <summary>
        /// Compares an object to the current ContentType instance.
        /// </summary>
        /// <param name="obj">The object to compare.</param>
        /// <returns>true if they are equal.</returns>
        public override bool Equals(object obj)
        {
            return this.Equals((ContentType)obj);
        }

        /// <summary>
        /// Compares another ContentType instance to this one.
        /// </summary>
        /// <param name="obj">The ContentType to compare.</param>
        /// <returns>true if they are equal.</returns>
        public bool Equals(ContentType obj)
        {
            if (this._contentType == obj._contentType)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// todo: Document.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Gives the textual representation of the contentType, as a number.
        /// </summary>
        /// <returns>A string containing the contentType number.</returns>
        public override string ToString()
        {
            return this._contentType.ToString();
        }
    }
}
